using EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Simple.Admin.Domain.Systems;
using Simple.Admin.Domain.Users;
using System.Text.Json;

namespace Simple.Admin.EntityFrameworkCore;

public static class SimpleEntityFrameworkCoreExtensions
{
    public static ModelBuilder ConfigureSimple(this ModelBuilder builder)
    {
        builder.Entity<UserInfo>(x =>
        {
            x.ToTable("UserInfos");

            x.AddSimpleConfigure();

        });

        builder.Entity<DictionarySetting>(x =>
        {
            x.ToTable("DictionarySettings");

            x.AddSimpleConfigure();

            x.HasIndex(x => x.Key);

            x.Property(x => x.Value)
                .HasConversion(x => JsonSerializer.Serialize(x, new JsonSerializerOptions()),
                    x => JsonSerializer.Deserialize<List<string>>(x, new JsonSerializerOptions()) ?? new List<string>());
        });

        return builder;
    }

}