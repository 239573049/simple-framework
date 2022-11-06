using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Token.Module;
using Token.Module.Attributes;

namespace Audit.Application;

[RunOrder(0)]
public class AuditApplicationModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<AuditMiddleware>();
    }

    public override void OnApplicationShutdown(IApplicationBuilder app)
    {
        app.UseMiddleware<AuditMiddleware>();
    }
}
