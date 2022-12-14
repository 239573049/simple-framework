using Serilog;
using Serilog.Events;
using Simple.Admin.HttpApi.Host;
using Token.Extensions;

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

await builder.Services.AddModuleApplicationAsync<SimpleHttpApiHostModule>();

var app = builder.Build();

app.InitializeApplication();

app.MapControllers();

app.Run();
