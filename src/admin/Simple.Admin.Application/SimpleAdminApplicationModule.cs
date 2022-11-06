using Microsoft.Extensions.DependencyInjection;
using Simple.Common.Jwt;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.Admin.Application;

[DependOn(typeof(SimpleCommonJwtModule))]
public class SimpleAdminApplicationModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(SimpleAdminApplicationModule));
    }
}