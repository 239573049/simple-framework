using EfCoreEntityFrameworkCore.Core;
using EfCoreEntityFrameworkCore.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Token.EntityFrameworkCore.Core;

namespace EfCoreEntityFrameworkCore
{
    public static class EfCoreEntityFrameworkCoreExtensions
    {
        /// <summary>
        /// 注册efCore基础服务
        /// </summary>
        /// <param name="services"></param>
        /// <typeparam name="TDbContext"></typeparam>
        /// <returns></returns>
        public static IServiceCollection AddEfCoreEntityFrameworkCore<TDbContext>(this IServiceCollection services)
            where TDbContext : MasterDbContext
        {
            ConfigureOptions(services);
            ConfigureDbContext<TDbContext>(services);
            
            // 注入工作单元
            services.AddTransient(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            return services;
        }

        /// <summary>
        /// 注入SqlServer的DbContext
        /// </summary>
        /// <param name="services"></param>
        /// <typeparam name="TDbContext"></typeparam>
        private static void ConfigureDbContext<TDbContext>(IServiceCollection services)
            where TDbContext : MasterDbContext
        {
            var simpleDbContextOptions =
                services.BuildServiceProvider().GetRequiredService<IOptions<SimpleDbContextOptions>>().Value;

            services.AddDbContext<TDbContext>(
                options => options.UseSqlServer(simpleDbContextOptions.Default));
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
    }
}