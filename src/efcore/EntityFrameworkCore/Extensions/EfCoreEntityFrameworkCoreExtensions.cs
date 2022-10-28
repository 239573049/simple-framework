using EntityFrameworkCore.Core;
using EntityFrameworkCore.Middlewares;
using EntityFrameworkCore.Options;
using EntityFrameworkCore.Shared.Base;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

namespace EntityFrameworkCore.Extensions
{
    public static class EfCoreEntityFrameworkCoreExtensions
    {
        /// <summary>
        /// 注册efCore基础服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionsAction"></param>
        /// <param name="lifetime"></param>
        /// <typeparam name="TDbContext"></typeparam>
        /// <returns></returns>
        public static IServiceCollection AddEfCoreEntityFrameworkCore<TDbContext>(this IServiceCollection services, Action<DbContextOptionsBuilder>? optionsAction = null,
            ServiceLifetime lifetime = ServiceLifetime.Singleton)
            where TDbContext : DbContext
        {
            ConfigureOptions(services);
            ConfigureDbContext<TDbContext>(services, optionsAction, lifetime);

            // 注入工作单元
            services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork<TDbContext>));

            return services;
        }

        /// <summary>
        /// 注入SqlServer的DbContext
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionsAction"></param>
        /// <param name="lifetime"></param>
        /// <typeparam name="TDbContext"></typeparam>
        private static void ConfigureDbContext<TDbContext>(IServiceCollection services, Action<DbContextOptionsBuilder>? optionsAction = null,
            ServiceLifetime lifetime = ServiceLifetime.Singleton)
            where TDbContext : DbContext
        {
            var simpleDbContextOptions =
                services.BuildServiceProvider().GetRequiredService<IOptions<SimpleDbContextOptions>>().Value;

            services.AddDbContextFactory<TDbContext>(optionsAction, lifetime);

        }

        /// <summary>
        /// 获取Options并且注入
        /// </summary>
        /// <param name="services"></param>
        private static void ConfigureOptions(IServiceCollection services)
        {
            var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
            services.Configure<SimpleDbContextOptions>(configuration.GetSection(SimpleDbContextOptions.Name));
        }

        /// <summary>
        /// 使用自动工作单元中间件
        /// </summary>
        /// <param name="app"></param>
        public static void UseUnitOfWorkMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<UnitOfWorkMiddleware>();
        }

        /// <summary>
        /// 注入工作单元中间件
        /// </summary>
        /// <param name="services"></param>
        public static IServiceCollection AddUnitOfWorkMiddleware(this IServiceCollection services)
        {
            services.AddTransient<UnitOfWorkMiddleware>();
            return services;
        }
    }
}