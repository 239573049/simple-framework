using EntityFrameworkCore.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Simple.Application;
using Simple.EntityFrameworkCore;
using Token.Module;
using Token.Module.Attributes;

namespace Test.Simple.HttpApi;

[DependOn(typeof(SimpleApplicationModule), typeof(SimpleEntityFrameworkCoreModule))]
public class TestSimpleHttpApiModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();

        // 注入自动事务中间件
        services.AddUnitOfWorkMiddleware();
    }


    public override void OnApplicationShutdown(IApplicationBuilder app)
    {
        app.UseAuthorization();

        // 注册自动工作单元中间件
        app.UseUnitOfWorkMiddleware();
    }
}