using Simple.Domain.Base;

namespace Simple.Auth.Domain.Roles;

public class UserRole : Entity
{
    /// <summary>
    /// 关联指定用户
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// 关联指定角色
    /// </summary>
    public Guid RoleId { get; set; }
}