using System.Reflection;
using EntityFrameworkCore;
using EntityFrameworkCore.Attributes;
using Microsoft.EntityFrameworkCore;
using Simple.Domain.Users;

namespace Simple.EntityFrameworkCore;

[ConnectionStringName]
public class SimpleDbContext : MasterDbContext<SimpleDbContext>
{
    public DbSet<UserInfo>? UserInfo { get; set; }

    public SimpleDbContext(DbContextOptions<SimpleDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        builder.ConfigureSimple();
    }

}