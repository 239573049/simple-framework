using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Simple.DbMigrations;
using Token.Module.Extensions;


IHostBuilder host =
    Host.CreateDefaultBuilder(args)
        .ConfigureAppConfiguration(options =>
        {

        })
        .ConfigureServices(async (hostContext, services) =>
        {
            await services.AddModuleApplicationAsync<SimpleDbMigrationsModule>();

            services.AddHostedService<DbMigratorHostedService>();
        });

await host.RunConsoleAsync();