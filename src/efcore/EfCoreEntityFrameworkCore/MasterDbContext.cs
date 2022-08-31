using System;
using System.Linq.Expressions;
using System.Reflection;
using EfCoreEntityFrameworkCore.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Simple.Common.Jwt;
using Simple.Domain.Base;
using Token.Module.Helpers;

namespace EfCoreEntityFrameworkCore
{
    public abstract class MasterDbContext<TDbContext> : DbContext
        where TDbContext : DbContext
    {
        private readonly SimpleDbContextOptions _simpleDbContextOptions;

        protected MasterDbContext(DbContextOptions<TDbContext> options) : base(options)
        {
            _simpleDbContextOptions = ServiceProviderHelper.ServiceProvider
                .GetService<IOptions<SimpleDbContextOptions>>().Value;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 禁用查询跟踪
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution);
#if DEBUG
            // 显示更详细的异常日志
            optionsBuilder.EnableDetailedErrors();
#endif
            
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            ConfigureSoftDelete(builder);

            ConfigureTenant(builder);
        }

        /// <summary>
        /// 过滤器增加软删除过滤
        /// </summary>
        /// <param name="builder"></param>
        private void ConfigureSoftDelete(ModelBuilder builder)
        {
            if (!_simpleDbContextOptions.SoftDelete)
                return;

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                //判断是否继承了软删除类
                if (!typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType)) continue;

                const string isDeleted = nameof(ISoftDelete.IsDeleted);
                builder.Entity(entityType.ClrType).Property<bool>(isDeleted);
                var parameter = Expression.Parameter(entityType.ClrType, isDeleted);

                // 添加过滤器
                var body = Expression.Equal(
                    Expression.Call(typeof(EF), nameof(EF.Property), new[] { typeof(bool) }, parameter,
                        Expression.Constant(isDeleted)),
                    Expression.Constant(false));

                builder.Entity(entityType.ClrType).HasQueryFilter(Expression.Lambda(body, parameter));
            }
        }


        private void ConfigureTenant(ModelBuilder builder)
        {
            if (!_simpleDbContextOptions.Tenant)
                return;

            var tenant = ServiceProviderHelper.ServiceProvider.GetRequiredService<ITenantManager>();

            const string tenanted = nameof(ITenant.TenantId);

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                // 是否继承租户基础类
                if (!typeof(ITenant).IsAssignableFrom(entityType.ClrType)) continue;

                builder.Entity(entityType.ClrType).Property<Guid?>(tenanted);

                var parameter = Expression.Parameter(entityType.ClrType, tenanted);

                if (tenant.GetTenantId() != null)
                {
                    // 添加租户过滤器
                    var body = Expression.Equal(
                        Expression.Call(typeof(EF), nameof(EF.Property),
                            new[] { typeof(Guid) }, parameter,
                            Expression.Constant(tenanted)),
                        Expression.Constant(tenant.GetTenantId()));

                    builder.Entity(entityType.ClrType).HasQueryFilter(Expression.Lambda(body, parameter));
                }
                else
                {
                    // 添加租户过滤器
                    var body = Expression.Equal(
                        Expression.Call(typeof(EF), nameof(EF.Property),
                            new[] { typeof(Guid?) }, parameter,
                            Expression.Constant(tenanted)),
                        Expression.Constant(null));

                    builder.Entity(entityType.ClrType).HasQueryFilter(Expression.Lambda(body, parameter));
                }
            }
        }
    }
}