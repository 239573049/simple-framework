using System.Reflection;
using EfCoreEntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Simple.Domain.Users;

namespace Simple.EntityFrameworkCore;

public class SimpleDbContext : MasterDbContext
{
    public DbSet<UserInfo>? UserInfo { get; set; }
    
    public SimpleDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        builder.ConfigureSimple();
    }
}