namespace Simple.Domain.Base;

public interface IHasDeleteCreator
{
    /// <summary>
    /// 删除人Id
    /// </summary>
    Guid? DeleteCreatorId { get; set; }

    /// <summary>
    /// 删除时间
    /// </summary>
    DateTime? DeleteTime { get; set; }
}