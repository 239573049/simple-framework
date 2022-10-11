using EntityFrameworkCore.Mysql;
using EntityFrameworkCore.Mysql.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.EntityFrameworkCore;

[DependOn(typeof(MysqlEntityFrameworkCoreModule))]
public class SimpleEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddMysqlEfCoreEntityFrameworkCore<SimpleDbContext>(new Version(8,0,10));
    }
}