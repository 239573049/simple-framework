using Microsoft.EntityFrameworkCore;
using Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;
using Simple.Admin.EntityFrameworkCore;
using System.Reflection;
using EntityFrameworkCore.DbMigrations.Extensions;

namespace EntityFrameworkCore.DbMigrations;

public class EfCoreMigrationDbContext : MasterDbContext<EfCoreMigrationDbContext>
{
    public EfCoreMigrationDbContext(DbContextOptions<EfCoreMigrationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // 程序的所有Entity配置
        builder.ConfigureSimple();
        builder.ConfigureAuth();

        // 初始化数据
        builder.ConfigureDefaultData();

    }

}