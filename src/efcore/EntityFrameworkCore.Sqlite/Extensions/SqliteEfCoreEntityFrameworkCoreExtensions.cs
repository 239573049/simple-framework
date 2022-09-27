using System.Reflection;
using EntityFrameworkCore.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Token.Module.Extensions;

namespace EntityFrameworkCore.Sqlite.Extensions;

public static class SqliteEfCoreEntityFrameworkCoreExtensions
{
    public static IServiceCollection AddSqliteEfCoreEntityFrameworkCore<TDbContext>(this IServiceCollection services,
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
            x.UseSqlite(configuration.GetConnectionString(connectString.ConnectionString));
        }, ServiceLifetime.Scoped);

        return services;
    }
}