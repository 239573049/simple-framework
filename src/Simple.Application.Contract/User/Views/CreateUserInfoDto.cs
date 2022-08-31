using Simple.Domain.Shared;

namespace Simple.Application.Contract.User.Views;

public class CreateUserInfoDto
{
    /// <summary>
    /// 昵称
    /// </summary>
    public string? Name { get;  set; }

    /// <summary>
    /// 账号
    /// </summary>
    public string? UserName { get;  set; }

    /// <summary>
    /// 密码
    /// </summary>
    public string? PassWord { get;  set; }

    /// <summary>
    /// 头像
    /// </summary>
    public string? Avatar { get;  set; }
    
}