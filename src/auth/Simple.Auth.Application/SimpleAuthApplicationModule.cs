﻿using Microsoft.Extensions.DependencyInjection;
using Simple.Common.Jwt;

namespace Simple.Auth.Application;

[DependOn(typeof(SimpleCommonJwtModule))]
public class SimpleAuthApplicationModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        // mapper 注入
        services.AddAutoMapper(typeof(SimpleAuthApplicationModule));
    }
}