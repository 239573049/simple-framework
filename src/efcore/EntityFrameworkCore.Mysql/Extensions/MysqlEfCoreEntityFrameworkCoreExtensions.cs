using EntityFrameworkCore.Attributes;
using EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Token.Module.Extensions;

namespace EntityFrameworkCore.Mysql.Extensions;

public static class MysqlEfCoreEntityFrameworkCoreExtensions
{
    public static IServiceCollection AddMysqlEfCoreEntityFrameworkCore<TDbContext>(this IServiceCollection services,
        Version version, ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        where TDbContext : MasterDbContext<TDbContext>
    {
        var configuration = services.GetService<IConfiguration>();
        var connectString = typeof(TDbContext).GetCustomAttribute<ConnectionStringNameAttribute>();

        var connectionString = connectString?.ConnectionString ?? "Default";

        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentNullException(connectionString);
        }

        services.AddEfCoreEntityFrameworkCore<TDbContext>(x =>
        {
            x.UseMySql(configuration.GetConnectionString(connectionString),
                new MySqlServerVersion(version));

        }, serviceLifetime);

        return services;
    }
}