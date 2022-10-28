using EntityFrameworkCore.Mysql.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Simple.Auth.EntityFrameworkCore;
using Simple.Admin.EntityFrameworkCore;
using System;
using Token.Module;
using Token.Module.Attributes;

namespace EntityFrameworkCore.DbMigrations;

[DependOn(typeof(SimpleAdminEntityFrameworkCoreModule),
    typeof(SimpleAuthEntityFrameworkCoreModule))]
public class EntityFrameworkCoreDbMigrationsModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddMysqlEfCoreEntityFrameworkCore<EfCoreMigrationDbContext>(new Version(8, 0, 10));

    }
}