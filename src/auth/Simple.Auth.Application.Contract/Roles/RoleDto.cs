using Simple.Shared.Base;

namespace Simple.Auth.Application.Contract.Roles;

public class RoleDto : ITenant
{
    public Guid Id { get; set; }

    /// <summary>
    /// 角色名称
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 角色编号
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// 索引
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// 是否私有 私有无法删除
    /// </summary>
    public bool IsPrivate { get; set; }

    public Guid? TenantId { get; set; }
}