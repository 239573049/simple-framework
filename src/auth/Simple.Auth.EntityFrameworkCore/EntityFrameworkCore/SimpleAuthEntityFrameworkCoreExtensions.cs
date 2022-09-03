using EfCoreEntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Simple.Auth.Domain.Roles;

namespace Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;

public static class SimpleAuthEntityFrameworkCoreExtensions
{
    public static ModelBuilder ConfigureAuth(this ModelBuilder builder)
    {
        builder.Entity<SimpleRole>(x=>
        {
            x.ToTable("SimpleRole");

            x.AddSimpleConfigure();
        });
        return builder;
    }
}