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
        services.AddControllers();
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
        var evn = app.ApplicationServices.GetService<IWebHostEnvironment>();
        // 只有在 Development 才运行Swagger UI
        if (evn.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        
        app.UseHttpsRedirection();

        app.UseAuthorization();

        // 注册自动工作单元中间件
        app.UseUnitOfWorkMiddleware();
    }
}