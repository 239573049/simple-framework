using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Simple.Auth.Application.Contract.Auth;
using Simple.Auth.Application.Contract.Auth.Dtos;
using Simple.Common.Jwt;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Options;
using Simple.Admin.Domain.Shared;
using Simple.Shared;
using TokenOptions = Simple.Common.Jwt.TokenOptions;

namespace Simple.Auth.HttpApi.Host.Controllers;

/// <summary>
/// 授权模块
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    private readonly TokenOptions _tokenOptions;
    /// <inheritdoc />
    public AuthController(IAuthService authService, IOptions<TokenOptions> tokenOptions)
    {
        _authService = authService;
        _tokenOptions = tokenOptions.Value;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost("sign-on")]
    public async Task<string> SignOnAsync(SignOnInput input)
    {
        var userInfo = await _authService.SignOnAsync(input);
        var roles = userInfo.Roles.Select(x => new Claim(ClaimsIdentity.DefaultRoleClaimType, x.Code)).ToList();

        roles.AddRange(userInfo.Roles.Select(x => new Claim(Constant.RoleId, x.Id.ToString())).ToList());

        roles.Add(new Claim(Constant.Id, userInfo.Id.ToString()));
        roles.Add(new Claim(Constant.User, JsonSerializer.Serialize(userInfo)));

        var cred = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOptions.SecretKey!)),
            SecurityAlgorithms.HmacSha256);
        var jwtSecurityToken = new JwtSecurityToken(
            _tokenOptions.Issuer, // 签发者
            _tokenOptions.Audience, // 接收者
            roles, // payload
            expires: DateTime.Now.AddMinutes(_tokenOptions.ExpireMinutes), // 过期时间
            signingCredentials: cred); // 令牌

        var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

        return token;
    }
}
