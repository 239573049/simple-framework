using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Simple.Common.Jwt;
using Simple.Domain.Base;
using Simple.Domain.Shared;
using Token.Module;
using Token.Module.Attributes;

namespace EfCoreEntityFrameworkCore;

[DependOn(typeof(SimpleCommonJwtModule))]
public class EfCoreEntityFrameworkCoreModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<ITenantManager,TenantManager>();
        
    }
}