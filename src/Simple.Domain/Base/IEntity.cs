namespace Simple.Domain.Base;

public interface IEntity<out TKey>
{
    TKey Id { get; }
}

public interface IEntity
{
    Guid Id { get; }
}