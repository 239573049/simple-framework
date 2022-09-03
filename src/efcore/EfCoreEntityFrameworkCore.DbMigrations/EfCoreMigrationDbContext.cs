using Microsoft.EntityFrameworkCore;
using Simple.EntityFrameworkCore;
using System.Reflection;
using Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;

namespace EfCoreEntityFrameworkCore.DbMigrations;

public class EfCoreMigrationDbContext : MasterDbContext<EfCoreMigrationDbContext>
{
    public EfCoreMigrationDbContext(DbContextOptions<EfCoreMigrationDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        builder.ConfigureSimple();
        builder.ConfigureAuth();
    }

}