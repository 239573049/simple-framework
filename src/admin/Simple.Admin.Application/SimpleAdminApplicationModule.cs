using Microsoft.Extensions.DependencyInjection;
using Token.Module;

namespace Simple.Admin.Application;

public class SimpleAdminApplicationModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(SimpleAdminApplicationModule));
    }
}