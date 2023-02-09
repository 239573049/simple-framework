using Microsoft.AspNetCore.Identity;

namespace Simple.Auth.Component.Domain;

public class ApplicationUser : IdentityUser
{
    /// <summary>
    /// 密码
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 头像
    /// </summary>
    public string? Avatar { get; set; }
}
