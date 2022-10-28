using Simple.Auth.Application.Contract.Auth.Dtos;

namespace Simple.Auth.Application.Contract.Auth;

public interface IAuthService
{
    /// <summary>
    /// 登录
    /// </summary>
    /// <returns></returns>
    Task<AuthUserInfoDto> SignOnAsync(SignOnInput input);
}