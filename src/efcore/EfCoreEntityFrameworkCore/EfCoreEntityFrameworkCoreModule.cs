using Microsoft.Extensions.DependencyInjection;
using Simple.Common.Jwt;
using Token.Module;
using Token.Module.Attributes;
using Token.Module.Extensions;

namespace EfCoreEntityFrameworkCore;

[DependOn(typeof(SimpleCommonJwtModule))]
public class EfCoreEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
    }
}