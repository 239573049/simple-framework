using Microsoft.EntityFrameworkCore;
using Simple.EntityFrameworkCore;
using System.Reflection;

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
    }

}