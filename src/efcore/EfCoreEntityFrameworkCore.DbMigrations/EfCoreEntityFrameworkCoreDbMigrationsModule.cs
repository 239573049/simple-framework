using Microsoft.Extensions.DependencyInjection;
using Token.Module;
using Token.Module.Attributes;

namespace EfCoreEntityFrameworkCore.DbMigrations;

[DependOn(typeof(EfCoreEntityFrameworkCoreModule))]
public class EfCoreEntityFrameworkCoreDbMigrationsModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddEfCoreEntityFrameworkCore<EfCoreMigrationDbContext>();
    }
}