using System;
using System.Linq.Expressions;
using System.Reflection;
using EfCoreEntityFrameworkCore.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Simple.Common.Jwt;
using Simple.Domain.Base;

namespace EfCoreEntityFrameworkCore
{
    public abstract class MasterDbContext : DbContext
    {
        protected MasterDbContext(DbContextOptions options) : base(options)
        {
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


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // 扫描配置
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            var dbContextOptions = ((IInfrastructure<IServiceProvider>)this).Instance
                .GetService<IOptions<SimpleDbContextOptions>>()?.Value;

            ConfigureSoftDelete(builder, dbContextOptions);
            ConfigureTenant(builder, dbContextOptions);
        }

        /// <summary>
        /// 过滤器增加软删除过滤
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="simpleDbContextOptions"></param>
        private static void ConfigureSoftDelete(ModelBuilder builder, SimpleDbContextOptions? simpleDbContextOptions)
        {
            if (simpleDbContextOptions?.SoftDelete == false)
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
        
        private void ConfigureTenant(ModelBuilder builder, SimpleDbContextOptions? simpleDbContextOptions)
        {
            if (simpleDbContextOptions?.Tenant == false)
            {
                return;
            }

            var tenant = ((IInfrastructure<IServiceProvider>)this).Instance.GetService<ICurrentManage>();

            const string tenantid = nameof(ITenant.TenantId);

            // 如果租户id为空获取租户id为空的数据
            if (tenant.GetTenantId() == null)
            {
                foreach (var entityType in builder.Model.GetEntityTypes())
                {
                    //判断是否继承了软删除类
                    if (!typeof(ITenant).IsAssignableFrom(entityType.ClrType)) continue;


                    builder.Entity(entityType.ClrType).Property<Guid?>(tenantid);

                    var parameter = Expression.Parameter(entityType.ClrType, tenantid);

                    // 添加过滤器
                    var body = Expression.Equal(
                        Expression.Call(typeof(EF), nameof(EF.Property), new[] { typeof(Guid?) }, parameter,
                            Expression.Constant(null)),
                        Expression.Constant(null));

                    builder.Entity(entityType.ClrType).HasQueryFilter(Expression.Lambda(body, parameter));
                }

                return;
            }

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                //判断是否继承了软删除类
                if (!typeof(ITenant).IsAssignableFrom(entityType.ClrType)) continue;

                builder.Entity(entityType.ClrType).Property<Guid?>(tenantid);

                var parameter = Expression.Parameter(entityType.ClrType, tenantid);

                // 添加过滤器
                var body = Expression.Equal(
                    Expression.Call(typeof(EF), nameof(EF.Property), new[] { typeof(Guid) }, parameter,
                        Expression.Constant(tenant.GetTenantId())),
                    Expression.Constant(tenant.GetTenantId()));

                builder.Entity(entityType.ClrType).HasQueryFilter(Expression.Lambda(body, parameter));
            }
        }
    }
}