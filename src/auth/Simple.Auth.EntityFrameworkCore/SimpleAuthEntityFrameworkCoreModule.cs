using EfCoreEntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;
using Token.Module;

namespace Simple.Auth.EntityFrameworkCore;

public class SimpleAuthEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddEfCoreEntityFrameworkCore<AuthDbContext>();
    }
}