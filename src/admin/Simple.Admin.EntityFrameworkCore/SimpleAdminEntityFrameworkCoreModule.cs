using EntityFrameworkCore.SqlServer;
using EntityFrameworkCore.SqlServer.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Token;

namespace Simple.Admin.EntityFrameworkCore;

[DependOn(typeof(SqlServerEntityFrameworkCoreModule))]
public class SimpleAdminEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddSqlServerEfCoreEntityFrameworkCore<SimpleDbContext>();
    }
}