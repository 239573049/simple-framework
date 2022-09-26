using EntityFrameworkCore;
using EntityFrameworkCore.Attributes;
using Microsoft.EntityFrameworkCore;
using Simple.Auth.Domain.Menus;
using Simple.Auth.Domain.Roles;

namespace Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;

[ConnectionStringName]
public class AuthDbContext : MasterDbContext<AuthDbContext>
{
    public DbSet<SimpleRole> SimpleRole { get; set; } = null!;

    public DbSet<UserRole> UserRole { get; set; } = null!;

    public DbSet<MenuRole> MenuRole { get; set; } = null!;

    public DbSet<Menu> Menu { get; set; } = null!;

    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.ConfigureAuth();
    }
}