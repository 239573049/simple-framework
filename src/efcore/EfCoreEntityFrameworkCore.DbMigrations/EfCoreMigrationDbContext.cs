using Microsoft.EntityFrameworkCore;
using Simple.EntityFrameworkCore;

namespace EfCoreEntityFrameworkCore.DbMigrations;

public class EfCoreMigrationDbContext : MasterDbContext
{
    public EfCoreMigrationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ConfigureSimple();
    }
}