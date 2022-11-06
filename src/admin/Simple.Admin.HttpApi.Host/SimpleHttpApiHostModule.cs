using EntityFrameworkCore.Extensions;
using NSwag;
using NSwag.Generation.Processors.Security;
using Simple.Admin.HttpApi.Host.Filters;
using Simple.Admin.Application;
using Simple.Admin.EntityFrameworkCore;
using Token.Module;
using Token.Module.Attributes;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Simple.Admin.HttpApi.Host;

[DependOn(typeof(SimpleAdminApplicationModule), typeof(SimpleAdminEntityFrameworkCoreModule))]
public class SimpleHttpApiHostModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        // 注入自动事务中间件
        services.AddUnitOfWorkMiddleware();

        ConfigureSwaggerServices(services);

        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", corsBuilder =>
            {
                corsBuilder.SetIsOriginAllowed((string _) => true).AllowAnyMethod().AllowAnyHeader()
                    .AllowCredentials();
            });
        });

        // 添加过滤器
        services.AddMvcCore(options =>
        {
            options.Filters.Add<ResponseFilter>();
            options.Filters.Add<ExceptionFilter>();
        });
    }

    /// <summary>
    /// 配置swagger
    /// </summary>
    /// <param name="services"></param>
    private static void ConfigureSwaggerServices(IServiceCollection services)
    {
        services.AddSwaggerDocument(config =>
        {
            config.UseControllerSummaryAsTagDescription = true;
            config.PostProcess = document =>
            {
                document.Info.Version = "admin-v1.0";
                document.Info.Title = "Admin Api";
                document.Info.Description = "Simple Api";
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

        // 注册自动工作单元中间件
        app.UseUnitOfWorkMiddleware();

        app.UseCors("CorsPolicy");
    }
}