using Microsoft.Extensions.DependencyInjection;
using Simple.Application.Contract;
using Simple.EntityFrameworkCore;
using Token.Module;
using Token.Module.Attributes;

namespace Simple.Application
{
    [DependOn(typeof(SimpleEntityFrameworkCoreModule))]
    public class SimpleApplicationModule : TokenModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IUserInfoService, UserInfoService>();
        }
    }
}