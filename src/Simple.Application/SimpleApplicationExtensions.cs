using System;
using Microsoft.Extensions.DependencyInjection;
using Simple.Application.Contract;
using Simple.EntityFrameworkCore;

namespace Simple.Application
{
    public static class SimpleApplicationExtensions
    {
        public static IServiceCollection AddSimpleApplication(this IServiceCollection services)
        {
            services.AddSimpleEntityFrameworkCore();
            services.AddTransient<IUserInfoService, UserInfoService>();
            return services;
        }
    }
}