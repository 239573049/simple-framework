using EntityFrameworkCore.Attributes;
using EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Token.Extensions;

namespace EntityFrameworkCore.Sqlite.Extensions;

public static class SqliteEfCoreEntityFrameworkCoreExtensions
{
    public static IServiceCollection AddSqliteEfCoreEntityFrameworkCore<TDbContext>(this IServiceCollection services)
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
            x.UseSqlite(configuration.GetConnectionString(connectionString));

        }, ServiceLifetime.Scoped);

        return services;
    }
}