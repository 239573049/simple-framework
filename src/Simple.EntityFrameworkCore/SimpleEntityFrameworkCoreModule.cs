using EfCoreEntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Simple.Domain.Users;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.EntityFrameworkCore;

[DependOn(typeof(EfCoreEntityFrameworkCoreModule))]
public class SimpleEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddEfCoreEntityFrameworkCore<SimpleDbContext>();
        
        services.AddTransient(typeof(IUserInfoRepository),typeof(EfCoreUserInfoRepository));
    }
}