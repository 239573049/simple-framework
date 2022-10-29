using EntityFrameworkCore.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Simple.Admin.Application;
using Simple.Admin.EntityFrameworkCore;
using Token.Module;
using Token.Module.Attributes;

namespace Test.Simple.HttpApi;

[DependOn(typeof(SimpleAdminApplicationModule), typeof(SimpleAdminEntityFrameworkCoreModule))]
public class TestSimpleHttpApiModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        // 注入自动事务中间件
        services.AddUnitOfWorkMiddleware();
    }


    public override void OnApplicationShutdown(IApplicationBuilder app)
    {
        // 注册自动工作单元中间件
        app.UseUnitOfWorkMiddleware();
    }
}