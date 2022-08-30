using Microsoft.Extensions.DependencyInjection;
using Token.Module;

namespace EfCoreEntityFrameworkCore.DbMigrations
{
    public class EfCoreEntityFrameworkCoreDbMigrationsModule : TokenModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddEfCoreEntityFrameworkCore<EfCoreMigrationDbContext>();
        }
    }
}