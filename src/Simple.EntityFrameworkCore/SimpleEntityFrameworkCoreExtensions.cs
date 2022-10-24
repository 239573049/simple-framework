using EntityFrameworkCore.Extensions;
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

            x.AddSimpleConfigure();

            x.HasIndex(info => info.Id).IsUnique();
        });

        return builder;
    }
}