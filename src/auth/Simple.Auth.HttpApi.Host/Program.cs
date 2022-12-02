using Serilog;
using Serilog.Events;
using Simple.Auth.HttpApi.Host;
using Token.Extensions;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .ReadFrom.Configuration(new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json",// ���ݻ�����������ָ������
            optional: true).Build())
    .Enrich.FromLogContext()
    .WriteTo.Async(c => c.File(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "/log/", "log"),
        rollingInterval: RollingInterval.Day)) // д����־���ļ�
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