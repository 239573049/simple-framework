using EfCoreEntityFrameworkCore;
using Simple.Application;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.HttpApi.Host;

[DependOn(typeof(SimpleApplicationModule))]
public class SimpleHttpApiHostModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddEndpointsApiExplorer()
            .AddSwaggerGen()
            .AddUnitOfWorkMiddleware();
    }

    public override void OnApplicationShutdown(IApplicationBuilder app)
    {
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.UseUnitOfWorkMiddleware();
    }
}