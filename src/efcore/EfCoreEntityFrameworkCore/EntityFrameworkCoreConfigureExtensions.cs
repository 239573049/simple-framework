using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simple.Domain.Base;

namespace EfCoreEntityFrameworkCore;

public static class EntityFrameworkCoreConfigureExtensions
{
    public static void AddSimpleConfigure<TEntity>(this EntityTypeBuilder<TEntity> builder) where TEntity : AggregateRoot<Guid>
    {
        builder.HasIndex(x => x.Id);
        builder.HasKey(x => x.Id);
        
        
    }
}