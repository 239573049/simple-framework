using System;
using Simple.Admin.Domain.Shared;

namespace Simple.Admin.Application.Contract.User.Views;

public class UserInfoDto
{
    public Guid Id { get; set; }

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
}