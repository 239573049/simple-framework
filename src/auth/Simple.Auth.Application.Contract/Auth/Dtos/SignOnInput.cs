namespace Simple.Auth.Application.Contract.Auth.Dtos;

public class SignOnInput
{
    /// <summary>
    /// 用户名
    /// </summary>
    public string? Username { get; set; }

    /// <summary>
    /// 密码
    /// </summary>
    public string? Password { get; set; }
}