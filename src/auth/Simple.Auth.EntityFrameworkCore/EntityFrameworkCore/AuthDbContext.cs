using EfCoreEntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Simple.Auth.Domain.Menus;
using Simple.Auth.Domain.Roles;

namespace Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;

public class AuthDbContext : MasterDbContext<AuthDbContext>
{
    public DbSet<SimpleRole> SimpleRole { get; set; }

    public DbSet<UserRole> UserRole { get; set; }

    public DbSet<MenuRole> MenuRole { get; set; }

    public DbSet<Menu> Menu { get; set; }

    
    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.ConfigureAuth();
    }
}