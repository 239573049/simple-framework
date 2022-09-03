using Microsoft.Extensions.DependencyInjection;
using Simple.Auth.EntityFrameworkCore;
using Token.Module;
using Token.Module.Attributes;

namespace EfCoreEntityFrameworkCore.DbMigrations;

[DependOn(typeof(EfCoreEntityFrameworkCoreModule),
    typeof(SimpleAuthEntityFrameworkCoreModule))]
public class EfCoreEntityFrameworkCoreDbMigrationsModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddEfCoreEntityFrameworkCore<EfCoreMigrationDbContext>();
    }
}