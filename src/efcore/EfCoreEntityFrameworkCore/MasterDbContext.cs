using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
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

            ConfigureSoftDelete(builder);
        }

        /// <summary>
        /// 过滤器增加软删除过滤
        /// </summary>
        /// <param name="builder"></param>
        private static void ConfigureSoftDelete(ModelBuilder builder)
        {
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
    }
}