namespace Simple.Auth.Application.Contract.Menus;

public class CreateMenuDto
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
}