using Microsoft.Extensions.DependencyInjection;
using Simple.Auth.EntityFrameworkCore;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.Auth.Application;

[DependOn(
    typeof(SimpleAuthEntityFrameworkCoreModule))]
public class SimpleAuthApplicationModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        // mapper 注入
        services.AddAutoMapper(typeof(SimpleAuthApplicationModule));
    }
}