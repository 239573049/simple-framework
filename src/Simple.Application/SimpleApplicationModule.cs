using Microsoft.Extensions.DependencyInjection;
using Token.Module;

namespace Simple.Application;

public class SimpleApplicationModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(SimpleApplicationModule));
    }
}