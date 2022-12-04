using Microsoft.AspNetCore.Builder;
using Simple.AuditLog.Middleware;
using Token;

namespace Simple.AuditLog;

public class SimpleAuditLogModule : TokenModule
{
    public override void OnApplicationShutdown(IApplicationBuilder app)
    {
        app.UseMiddleware<SimpleAuditLogMiddleware>();
    }
}