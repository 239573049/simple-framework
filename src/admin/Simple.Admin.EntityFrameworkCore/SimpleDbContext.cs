using EntityFrameworkCore;
using EntityFrameworkCore.Attributes;
using Microsoft.EntityFrameworkCore;
using Simple.Admin.Domain.Systems;
using Simple.Admin.Domain.Users;
using System.Reflection;

namespace Simple.Admin.EntityFrameworkCore;

[ConnectionStringName]
public class SimpleDbContext : MasterDbContext<SimpleDbContext>
{
    public DbSet<UserInfo>? UserInfo { get; set; } = null!;

    public DbSet<DictionarySetting> DictionarySettings { get; set; } = null!;

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