using Microsoft.Extensions.DependencyInjection;
using Simple.EntityFrameworkCore;

namespace EfCoreEntityFrameworkCore.DbMigrations
{
    public static class EfCoreEntityFrameworkCoreDbMigrationsExtensions
    {
        public static IServiceCollection AddEfCoreEntityFrameworkCoreDbMigrations(this IServiceCollection services)
        {
            services.AddEfCoreEntityFrameworkCore<EfCoreMigrationDbContext>();
            return services;
        }
    }
}