using System.Reflection;
using EntityFrameworkCore.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Token.Module.Extensions;

namespace EntityFrameworkCore.SqlServer.Extensions;

public static class SqlServerEntityFrameworkCoreExtensions
{
    public static IServiceCollection AddSqlServerEfCoreEntityFrameworkCore<TDbContext>(this IServiceCollection services)
        where TDbContext : MasterDbContext<TDbContext>
    {
        var configuration = services.GetService<IConfiguration>();
        var connectString = typeof(TDbContext).GetCustomAttribute<ConnectionStringNameAttribute>();

        var connectionString = connectString?.ConnectionString ?? "Default";

        if(string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentNullException(connectionString);
        }

        services.AddEfCoreEntityFrameworkCore<TDbContext>(
            x => { x.UseSqlServer(configuration.GetConnectionString(connectionString)); },
            ServiceLifetime.Scoped);

        return services;
    }
}