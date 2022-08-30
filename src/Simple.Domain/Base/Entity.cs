namespace Simple.Domain.Base;

public abstract class Entity<TKey> : IEntity<TKey>
{
    protected Entity(TKey id) => Id = id;

    protected Entity()
    {
    }

    public TKey Id { get; protected set; }
}
