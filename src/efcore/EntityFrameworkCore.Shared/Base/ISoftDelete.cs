namespace EntityFrameworkCore.Shared.Base
{
    public interface ISoftDelete
    {
        /// <summary>用于将实体标记为“已删除”。</summary>
        bool IsDeleted { get; set; }
    }
}