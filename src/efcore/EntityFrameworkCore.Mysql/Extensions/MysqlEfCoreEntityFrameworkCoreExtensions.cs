using System.Reflection;
using EntityFrameworkCore.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Token.Module.Extensions;

namespace EntityFrameworkCore.Mysql.Extensions;

public static class MysqlEfCoreEntityFrameworkCoreExtensions
{
    public static IServiceCollection AddMysqlEfCoreEntityFrameworkCore<TDbContext>(this IServiceCollection services,
        Version version)
        where TDbContext : MasterDbContext<TDbContext>
    {
        var configuration = services.GetService<IConfiguration>();
        var connectString = typeof(TDbContext).GetCustomAttribute<ConnectionStringNameAttribute>();

        if (string.IsNullOrEmpty(connectString?.ConnectionString))
        {
            throw new ArgumentNullException(connectString?.ConnectionString);
        }


        services.AddEfCoreEntityFrameworkCore<TDbContext>(x =>
        {
            x.UseMySql(configuration.GetConnectionString(connectString.ConnectionString),
                new MySqlServerVersion(version));
        }, ServiceLifetime.Scoped);

        return services;
    }
}