using EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Simple.Domain.Systems;
using Simple.Domain.Users;
using System.Text.Json;

namespace Simple.EntityFrameworkCore;

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

            x.Property(x => x.ExtraProperties)
                .HasConversion(x => JsonSerializer.Serialize(x, new JsonSerializerOptions()),
                    x => JsonSerializer.Deserialize<Dictionary<string, object>>(x, new JsonSerializerOptions()) ?? new Dictionary<string, object>());
        });
        return builder;
    }
}