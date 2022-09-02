using Microsoft.Extensions.DependencyInjection;
using Token.Module;

namespace Simple.Auth.Application;

public class SimpleAuthApplicationModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        // mapper 注入
        services.AddAutoMapper(typeof(SimpleAuthApplicationModule));
    }
}