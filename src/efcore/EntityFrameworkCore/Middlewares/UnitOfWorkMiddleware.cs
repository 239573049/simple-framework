using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkCore.Attributes;
using EntityFrameworkCore.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Options;
using Simple.Domain.Base;

namespace EntityFrameworkCore.Middlewares;

public class UnitOfWorkMiddleware : IMiddleware
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UnitOfWorkOptions _unitOfWorkOptions;

    public UnitOfWorkMiddleware(IUnitOfWork unitOfWork, IOptions<UnitOfWorkOptions> unitOfWorkOptions)
    {
        _unitOfWork = unitOfWork;
        _unitOfWorkOptions = unitOfWorkOptions.Value;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        if (!_unitOfWorkOptions.Enable || IsIgnoredUrl(context))
        {
            await next(context).ConfigureAwait(false);
        }

        var unitOfWorkAttribute = context.Features.Get<IEndpointFeature>()?.Endpoint?.Metadata
            .GetMetadata<DisabledUnitOfWorkAttribute>();

        if (unitOfWorkAttribute?.Disabled == true)
        {
            await next.Invoke(context);
        }
        else
        {
            await _unitOfWork.BeginTransactionAsync();
            await next.Invoke(context);
            await _unitOfWork.CommitTransactionAsync();
        }
    }

    private bool IsIgnoredUrl(HttpContext context) => context.Request.Path.Value != null &&
                                                      _unitOfWorkOptions.IgnoredUrl.Any(
                                                          x =>
                                                              context.Request.Path.Value.StartsWith(x));
}