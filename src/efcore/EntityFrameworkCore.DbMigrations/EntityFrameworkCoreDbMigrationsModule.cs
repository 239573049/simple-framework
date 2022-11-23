using EntityFrameworkCore.SqlServer.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Simple.Admin.EntityFrameworkCore;
using Token.Module;
using Token.Module.Attributes;

namespace EntityFrameworkCore.DbMigrations;

[DependOn(typeof(SimpleAdminEntityFrameworkCoreModule))]
public class EntityFrameworkCoreDbMigrationsModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddSqlServerEfCoreEntityFrameworkCore<EfCoreMigrationDbContext>();
    }
}