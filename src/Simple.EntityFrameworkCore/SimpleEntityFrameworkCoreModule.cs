using EfCoreEntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Simple.Domain.Users;
using Token.Module;

namespace Simple.EntityFrameworkCore;

public class SimpleEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddEfCoreEntityFrameworkCore<SimpleDbContext>();
        
        services.AddTransient(typeof(IUserInfoRepository),typeof(EfCoreUserInfoRepository));
    }
}