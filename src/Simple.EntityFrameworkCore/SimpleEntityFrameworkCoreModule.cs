using EntityFrameworkCore.Sqlite;
using EntityFrameworkCore.Sqlite.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.EntityFrameworkCore;

[DependOn(typeof(SqliteEntityFrameworkCoreModule))]
public class SimpleEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddSqliteEfCoreEntityFrameworkCore<SimpleDbContext>();
    }
}