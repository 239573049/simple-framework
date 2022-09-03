using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using Simple.Domain.Base;

namespace EfCoreEntityFrameworkCore;

public static class EntityFrameworkCoreConfigureExtensions
{
    public static void AddSimpleConfigure<TEntity>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : AggregateRoot<Guid>
    {
        builder.HasIndex(x => x.Id);
        builder.HasKey(x => x.Id);

        builder.Property(x => x.ExtraProperties)
            .HasConversion(x => JsonConvert.SerializeObject(x),
                x => JsonConvert.DeserializeObject<Dictionary<string, object>>(x) ?? new Dictionary<string, object>());
    }
}