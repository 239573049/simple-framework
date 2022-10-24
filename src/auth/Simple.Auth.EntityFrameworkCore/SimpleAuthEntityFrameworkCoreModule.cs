using EntityFrameworkCore.Mysql;
using EntityFrameworkCore.Mysql.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.Auth.EntityFrameworkCore;

[DependOn(typeof(MysqlEntityFrameworkCoreModule))]
public class SimpleAuthEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddMysqlEfCoreEntityFrameworkCore<AuthDbContext>(new Version(8, 0, 10));
    }
}