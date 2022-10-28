using Serilog;
using Serilog.Events;
using Simple.Auth.HttpApi.Host;
using Token.Module.Extensions;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .ReadFrom.Configuration(new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json",// 根据环境变量加载指定配置
            optional: true).Build())
    .Enrich.FromLogContext()
    .WriteTo.Async(c => c.File(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "/log/", "log"),
        rollingInterval: RollingInterval.Day)) // 写入日志到文件
    .WriteTo.Async(c => c.Console())
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog();

var services = builder.Services;

await services.AddModuleApplicationAsync<SimpleAuthHttpApiHostModule>();

var app = builder.Build();

app.InitializeApplication();

app.MapControllers();

app.Run();