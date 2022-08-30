
using EfCoreEntityFrameworkCore.DbMigrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

IHostBuilder host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((configure) =>
    {
        configure.AddJsonFile("appsettings.json").Build();
    })
    .ConfigureServices(((context, services) =>
    {
        services.AddEfCoreEntityFrameworkCoreDbMigrations();
    }));

host.RunConsoleAsync();