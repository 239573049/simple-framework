using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Simple.AuditLog.Options;
using Token.Dependency;
using Token.Events;

namespace Simple.AuditLog.Middleware;

public class SimpleAuditLogMiddleware : IMiddleware, ITransientDependency
{
    private readonly SimpleAuditLogOptions _simpleAuditLogOptions;
    private readonly ILoadEventBus<SimpleAuditLogEto> _loadEventBus;

    public SimpleAuditLogMiddleware(IServiceProvider serviceProvider, ILoadEventBus<SimpleAuditLogEto> loadEventBus)
    {
        _loadEventBus = loadEventBus;
        _simpleAuditLogOptions = serviceProvider.GetService<IOptions<SimpleAuditLogOptions>>()?.Value ?? new SimpleAuditLogOptions();
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        await next.Invoke(context);

        await _loadEventBus.PushAsync(new SimpleAuditLogEto()
        {
            AppServerName = _simpleAuditLogOptions.AppServerName,
            Code = context.Response.StatusCode,
            Ip = context.Request.HttpContext.Connection.LocalIpAddress.MapToIPv4().ToString(),
            Path = context.Request.Path,
            Query = context.Request.QueryString.Value,
            Succeed = context.Response.StatusCode == 200
        });
    }
}