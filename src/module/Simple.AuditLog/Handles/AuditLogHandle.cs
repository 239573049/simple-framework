using Token.Dependency;
using Token.Handlers;

namespace Simple.AuditLog.Handles;

public class AuditLogHandle : ILoadEventHandler<SimpleAuditLogEto>, ITransientDependency
{
    public async Task HandleEventAsync(SimpleAuditLogEto eventData)
    {
        await Task.CompletedTask;
    }
}