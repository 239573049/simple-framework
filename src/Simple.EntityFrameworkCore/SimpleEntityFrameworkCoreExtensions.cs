using Microsoft.EntityFrameworkCore;
using Simple.Domain.Users;

namespace Simple.EntityFrameworkCore;

public static class SimpleEntityFrameworkCoreExtensions
{
    public static ModelBuilder ConfigureSimple(this ModelBuilder builder)
    {
        builder.Entity<UserInfo>(x =>
        {
            x.ToTable("UserInfos");

            x.HasIndex(info => info.Id);
        });
        
        return builder;
    }
}