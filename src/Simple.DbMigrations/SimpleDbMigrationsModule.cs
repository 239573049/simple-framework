using EntityFrameworkCore.DbMigrations;
using Microsoft.Extensions.DependencyInjection;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.DbMigrations;

[DependOn(
    typeof(EntityFrameworkCoreDbMigrationsModule))]
public class SimpleDbMigrationsModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {

    }
}