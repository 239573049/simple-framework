using EntityFrameworkCore.SqlServer;
using EntityFrameworkCore.SqlServer.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;
using Token;
using Token.Attributes;

namespace Simple.Auth.EntityFrameworkCore;

[DependOn(typeof(SqlServerEntityFrameworkCoreModule))]
public class SimpleAuthEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddSqlServerEfCoreEntityFrameworkCore<AuthDbContext>();
    }
}