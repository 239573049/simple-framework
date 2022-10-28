using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text.Json;
using Simple.Shared.Base;

namespace EntityFrameworkCore.Extensions;

public static class EntityFrameworkCoreConfigureExtensions
{
    public static void AddSimpleConfigure<TEntity>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : AggregateRoot<Guid>
    {
        builder.HasIndex(x => x.Id).IsUnique();
        builder.HasKey(x => x.Id);

        builder.Property(x => x.ExtraProperties)
                .HasConversion(x => JsonSerializer.Serialize(x, new JsonSerializerOptions()),
                    x => JsonSerializer.Deserialize<Dictionary<string, object>>(x, new JsonSerializerOptions()) ?? new Dictionary<string, object>());
    }
}