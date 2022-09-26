using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Simple.Common.Jwt;
using Token.Module;
using Token.Module.Attributes;

namespace EfCoreEntityFrameworkCore;

[DependOn(typeof(SimpleCommonJwtModule))]
public class EfCoreEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddUnitOfWorkMiddleware();
    }

    public override void OnApplicationShutdown(IApplicationBuilder app)
    {
        app.UseUnitOfWorkMiddleware();
    }
}