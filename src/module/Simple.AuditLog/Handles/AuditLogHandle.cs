using Microsoft.Extensions.DependencyInjection;
using Token.Dependency;
using Token.Handlers;

namespace Simple.AuditLog.Handles;

public class AuditLogHandle : ILoadEventHandler<SimpleAuditLogEto>, ITransientDependency
{
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public AuditLogHandle(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }

    public async Task HandleEventAsync(SimpleAuditLogEto eventData)
    {
        await Task.CompletedTask;
    }
}