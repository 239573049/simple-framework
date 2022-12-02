using EntityFrameworkCore.DbMigrations;
using Microsoft.Extensions.DependencyInjection;
using Token;
using Token.Attributes;

namespace Simple.DbMigrations;

[DependOn(
    typeof(EntityFrameworkCoreDbMigrationsModule))]
public class SimpleDbMigrationsModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {

    }
}