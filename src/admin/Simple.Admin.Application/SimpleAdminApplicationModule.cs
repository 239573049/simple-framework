using Microsoft.Extensions.DependencyInjection;
using Simple.Admin.Domain.Systems;
using Simple.Common.Jwt;
using Simple.Shared.Base;

namespace Simple.Admin.Application;

[DependOn(typeof(SimpleCommonJwtModule))]
public class SimpleAdminApplicationModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(SimpleAdminApplicationModule));
    }
}