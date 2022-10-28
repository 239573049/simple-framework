using EntityFrameworkCore.Attributes;
using EntityFrameworkCore.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkCore.Shared.Base;

namespace EntityFrameworkCore.Middlewares;

public class UnitOfWorkMiddleware : IMiddleware
{
    private readonly UnitOfWorkOptions _unitOfWorkOptions;

    public UnitOfWorkMiddleware(IOptions<UnitOfWorkOptions> unitOfWorkOptions)
    {
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
            await next.Invoke(context).ConfigureAwait(false);
        }
        else
        {
            // 获取服务中多个DbContext
            var unitOfWorks = context.RequestServices.GetServices<IUnitOfWork>();
            foreach (var unitOfWork in unitOfWorks)
            {
                // 开启事务
                await unitOfWork.BeginTransactionAsync();
            }
            try
            {
                await next.Invoke(context);

                foreach (var unitOfWork in unitOfWorks)
                {
                    // 提交事务
                    await unitOfWork.CommitTransactionAsync();
                }
            }
            finally
            {
                foreach (var d in unitOfWorks)
                {
                    await d.RollbackTransactionAsync();
                }
            }
        }
    }

    private bool IsIgnoredUrl(HttpContext context) => context.Request.Path.Value != null &&
                                                      _unitOfWorkOptions.IgnoredUrl.Any(
                                                          x =>
                                                              context.Request.Path.Value.StartsWith(x));
}