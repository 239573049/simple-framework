using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Simple.DbMigrations;
using Token.Module.Extensions;

IHostBuilder host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((configure) =>
    {
        configure.AddJsonFile("appsettings.json").Build();
    })
    .ConfigureServices(((context, services) =>
    {
        services.AddModuleApplication<SimpleDbMigrationsModule>();
        
    }));

host.RunConsoleAsync();