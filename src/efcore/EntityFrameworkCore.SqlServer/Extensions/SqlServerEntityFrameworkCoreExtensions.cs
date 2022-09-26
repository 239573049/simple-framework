using System.Reflection;
using EntityFrameworkCore.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EntityFrameworkCore.SqlServer.Extensions;

public static class SqlServerEntityFrameworkCoreExtensions
{
    public static IServiceCollection AddSqlServerEfCoreEntityFrameworkCore<TDbContext>(this IServiceCollection services)
        where TDbContext : MasterDbContext<TDbContext>
    {
        var connectString = typeof(TDbContext).GetCustomAttribute<ConnectionStringNameAttribute>();

        if (string.IsNullOrEmpty(connectString?.ConnectionString))
        {
            throw new ArgumentNullException(connectString?.ConnectionString);
        }

        var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();

        services.AddEfCoreEntityFrameworkCore<TDbContext>(
            x => { x.UseSqlServer(configuration.GetConnectionString(connectString.ConnectionString)); },
            ServiceLifetime.Scoped);

        return services;
    }
}