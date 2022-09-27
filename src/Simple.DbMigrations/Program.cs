using Simple.DbMigrations;
using Token.Module.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
await builder.Services.AddModuleApplication<SimpleDbMigrationsModule>();

var app = builder.Build();

app.InitializeApplication();

app.MapControllers();

app.Run();
