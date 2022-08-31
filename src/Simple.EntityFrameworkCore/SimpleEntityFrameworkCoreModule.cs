using EfCoreEntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.EntityFrameworkCore;

[DependOn(typeof(EfCoreEntityFrameworkCoreModule))]
public class SimpleEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddEfCoreEntityFrameworkCore<SimpleDbContext>();
    }
}