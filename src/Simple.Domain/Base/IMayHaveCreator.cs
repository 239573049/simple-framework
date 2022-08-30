namespace Simple.Domain.Base;

public interface IMayHaveCreator
{
    /// <summary>
    /// 创建人
    /// </summary>
    Guid? CreatorId { get; set; }
}