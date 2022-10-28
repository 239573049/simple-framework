using System;

namespace EntityFrameworkCore.Shared.Base
{

    public abstract class Entity<TKey> : IEntity<TKey>
    {
        protected Entity(TKey id) => Id = id;

        protected Entity()
        {
        }

        public TKey Id { get; protected set; }
    }

    public abstract class Entity : IEntity
    {
        protected Entity(Guid id)
        {
            Id = id;
        }

        protected Entity()
        {
        }

        public Guid Id { get; }
    }
}