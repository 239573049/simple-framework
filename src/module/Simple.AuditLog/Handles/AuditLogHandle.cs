using Token.Handlers;

namespace Simple.AuditLog.Handles;

public class AuditLogHandle : ILoadEventHandler<SimpleAuditLogEto>
{
    public async Task HandleEventAsync(SimpleAuditLogEto eventData)
    {
        await Task.CompletedTask;
    }
}