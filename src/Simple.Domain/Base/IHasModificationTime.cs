namespace Simple.Domain.Base;

public interface IHasModificationTime
{
    /// <summary>
    /// 最后更新时间
    /// </summary>
    DateTime? LastModificationTime { get; set; }
}