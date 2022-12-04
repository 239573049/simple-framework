using EntityFrameworkCore.Core;
using EntityFrameworkCore.SqlServer;
using EntityFrameworkCore.SqlServer.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Simple.Admin.Domain.Systems;
using Simple.Shared.Base;
using Token;

namespace Simple.Admin.EntityFrameworkCore;

[DependOn(typeof(SqlServerEntityFrameworkCoreModule))]
public class SimpleAdminEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddSqlServerEfCoreEntityFrameworkCore<SimpleDbContext>();
        services.AddTransient(typeof(IRepository<DictionarySetting>),typeof(Repository<SimpleDbContext,DictionarySetting>));
    }
}