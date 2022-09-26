using System;
using EntityFrameworkCore.Mysql.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Simple.Auth.EntityFrameworkCore;
using Token.Module;
using Token.Module.Attributes;

namespace EntityFrameworkCore.DbMigrations;

[DependOn(typeof(EntityFrameworkCoreModule),
    typeof(SimpleAuthEntityFrameworkCoreModule))]
public class EntityFrameworkCoreDbMigrationsModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        var version = new Version(8,0,10);
        services.AddMysqlEfCoreEntityFrameworkCore<EfCoreMigrationDbContext>(version);
    }
}