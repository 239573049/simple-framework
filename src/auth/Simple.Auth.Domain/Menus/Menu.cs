using Simple.Domain.Base;

namespace Simple.Auth.Domain.Menus;

/// <summary>
/// 菜单
/// </summary>
public class Menu : AggregateRoot<Guid>, ITenant
{
    /// <summary>
    /// 标题
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 图标
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// 组件
    /// </summary>
    public string? Component { get; set; }

    /// <summary>
    /// 路由
    /// </summary>
    public string? Path { get; set; }

    /// <summary>
    /// 上级Id
    /// </summary>
    public Guid? ParentId { get; set; }

    public Guid? TenantId { get; set; }

    public Menu(Guid id, DateTime creationTime, DateTime? lastModificationTime, Guid? lastModifierId, bool isDeleted,
        Guid? creatorId, string? title, string? icon, int index, string? component, string? path, Guid? parentId,
        Guid? tenantId) : base(id, creationTime, lastModificationTime, lastModifierId, isDeleted, creatorId)
    {
        Title = title;
        Icon = icon;
        Index = index;
        Component = component;
        Path = path;
        ParentId = parentId;
        TenantId = tenantId;
    }

    public Menu(Guid id, string? title, string? icon, int index, string? component, string? path, Guid? parentId, Guid? tenantId) : base(id)
    {
        Title = title;
        Icon = icon;
        Index = index;
        Component = component;
        Path = path;
        ParentId = parentId;
        TenantId = tenantId;
    }

    protected Menu()
    {
    }
}