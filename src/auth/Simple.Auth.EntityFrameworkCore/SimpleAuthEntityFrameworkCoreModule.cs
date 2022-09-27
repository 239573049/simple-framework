using EntityFrameworkCore.Sqlite;
using EntityFrameworkCore.Sqlite.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.Auth.EntityFrameworkCore;

[DependOn(typeof(SqliteEntityFrameworkCoreModule))]
public class SimpleAuthEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddSqliteEfCoreEntityFrameworkCore<AuthDbContext>();
    }
}