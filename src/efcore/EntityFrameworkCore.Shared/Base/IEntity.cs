using System;

namespace EntityFrameworkCore.Shared.Base
{

    public interface IEntity<out TKey>
    {
        TKey Id { get; }
    }

    public interface IEntity
    {
        Guid Id { get; }
    }
}