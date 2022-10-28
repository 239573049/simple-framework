using Simple.Admin.Domain.Shared;
using Simple.Shared.Base;

namespace Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;

public class AuthUserInfo : AggregateRoot<Guid>, ITenant
{
    /// <summary>
    /// 昵称
    /// </summary>
    public string? Name { get; protected set; }

    /// <summary>
    /// 账号
    /// </summary>
    public string? UserName { get; protected set; }

    /// <summary>
    /// 密码
    /// </summary>
    public string? PassWord { get; protected set; }

    /// <summary>
    /// 头像
    /// </summary>
    public string? Avatar { get; protected set; }

    /// <summary>
    /// 账号状态
    /// </summary>
    public UserInfoStatus Status { get; protected set; }

    public Guid? TenantId { get; set; }
}