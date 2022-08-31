namespace Simple.Domain.Base;

public abstract class AggregateRoot<TKey> : Entity<TKey>, IHasCreationTime, IModificationAuditedObject, ISoftDelete,
    IMayHaveCreator,IHasDeleteCreator
{
    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool IsDeleted { get; set; }

    public Guid? CreatorId { get; set; }

    protected  AggregateRoot()
    {
    }

    protected  AggregateRoot(TKey id, DateTime creationTime, DateTime? lastModificationTime, Guid? lastModifierId, bool isDeleted, Guid? creatorId) : base(id)
    {
        CreationTime = creationTime;
        LastModificationTime = lastModificationTime;
        LastModifierId = lastModifierId;
        IsDeleted = isDeleted;
        CreatorId = creatorId;
    }

    protected  AggregateRoot(DateTime creationTime, DateTime? lastModificationTime, Guid? lastModifierId, bool isDeleted, Guid? creatorId)
    {
        CreationTime = creationTime;
        LastModificationTime = lastModificationTime;
        LastModifierId = lastModifierId;
        IsDeleted = isDeleted;
        CreatorId = creatorId;
    }

    public Guid? DeleteCreatorId { get; set; }
    
    public DateTime? DeleteTime { get; set; }
}