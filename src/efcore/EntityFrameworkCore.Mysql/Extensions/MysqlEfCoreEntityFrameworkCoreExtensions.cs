using System.Reflection;
using EntityFrameworkCore.Attributes;
using EntityFrameworkCore.Extensions;
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

        var connectionString = connectString?.ConnectionString ?? "Default";

        if(string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentNullException(connectionString);
        }


        services.AddEfCoreEntityFrameworkCore<TDbContext>(x =>
        {
            x.UseMySql(configuration.GetConnectionString(connectionString),
                new MySqlServerVersion(version));
        }, ServiceLifetime.Scoped);

        return services;
    }
}