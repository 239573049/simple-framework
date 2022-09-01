using EfCoreEntityFrameworkCore;
using Simple.Application;
using Simple.HttpApi.Host.Filters;
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

        // 添加过滤器
        services.AddMvcCore(options =>
        {
            options.Filters.Add<ResponseFilter>();
            options.Filters.Add<ExceptionFilter>();
        });
    }

    public override void OnApplicationShutdown(IApplicationBuilder app)
    {
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.UseUnitOfWorkMiddleware();
    }
}