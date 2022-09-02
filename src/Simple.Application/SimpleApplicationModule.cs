using Microsoft.Extensions.DependencyInjection;
using Simple.Application.Contract.User;
using Simple.Application.User;
using Simple.EntityFrameworkCore;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.Application;

[DependOn(typeof(SimpleEntityFrameworkCoreModule))]
public class SimpleApplicationModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(SimpleApplicationModule));
    }
}