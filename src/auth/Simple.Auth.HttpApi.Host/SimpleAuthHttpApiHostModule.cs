using EntityFrameworkCore.Extensions;
using NSwag;
using NSwag.Generation.Processors.Security;
using Simple.Auth.Application;
using Simple.Auth.EntityFrameworkCore;
using Simple.Auth.HttpApi.Host.Filters;
using Simple.HttpApi.Host.Filters;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.Auth.HttpApi.Host;

[DependOn(typeof(SimpleAuthApplicationModule), typeof(SimpleAuthEntityFrameworkCoreModule))]
public class SimpleAuthHttpApiHostModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddEndpointsApiExplorer();

        // 注入自动事务中间件
        services.AddUnitOfWorkMiddleware();

        ConfigureSwaggerServices(services);

        // 添加过滤器
        services.AddMvcCore(options =>
        {
            options.Filters.Add<ResponseFilter>();
            options.Filters.Add<ExceptionFilter>();
        });
    }

    private static void ConfigureSwaggerServices(IServiceCollection services)
    {
        services.AddSwaggerDocument(config =>
        {
            config.UseControllerSummaryAsTagDescription = true;
            config.PostProcess = document =>
            {
                document.Info.Version = "v1.0";
                document.Info.Title = "Auth Api";
                document.Info.Description = "Auth Api";
            };
            config.AddSecurity("bearer", Enumerable.Empty<string>(),
                new OpenApiSecurityScheme
                {
                    Type = OpenApiSecuritySchemeType.ApiKey,
                    Name = "Bearer"
                });
            config.OperationProcessors.Add(
                new AspNetCoreOperationSecurityScopeProcessor("bearer"));
        });
    }

    public override void OnApplicationShutdown(IApplicationBuilder app)
    {
        var evn = app.ApplicationServices.GetService<IWebHostEnvironment>();

        // 只有在 Development 才运行Swagger UI
        if (evn.IsDevelopment())
        {
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        // 注册自动工作单元中间件
        app.UseUnitOfWorkMiddleware();
    }
}