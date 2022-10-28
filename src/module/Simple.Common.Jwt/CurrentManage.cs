using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Simple.Admin.Domain.Shared;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using Simple.Shared.Base;
using Token.Module.Dependencys;
using Token.Module.Exceptions;

namespace Simple.Common.Jwt;

public class CurrentManage : ITransientDependency
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly TokenOptions _tokenOptions;

    public CurrentManage(IHttpContextAccessor httpContextAccessor, IOptions<TokenOptions> tokenOptions)
    {
        _httpContextAccessor = httpContextAccessor;
        _tokenOptions = tokenOptions.Value;
    }

    /// <inheritdoc />
    public bool? IsAuthenticated()
    {
        return _httpContextAccessor.HttpContext?.User.Identity?.IsAuthenticated;
    }

    /// <inheritdoc />
    public Guid? UserId()
    {
        var id = GetClaimValueByType(Constant.Id)?.FirstOrDefault();
        if (string.IsNullOrEmpty(id))
        {
            return default;
        }

        return Guid.Parse(id);
    }

    public Guid GetUserId()
    {
        var userId = UserId();

        if (userId == null)
        {
            throw new BusinessException("账号未登录", 401);
        }

        return (Guid)userId;
    }

    /// <inheritdoc />
    public T? UserInfo<T>()
    {
        var userInfo = GetClaimValueByType(ClaimTypes.Sid)?.FirstOrDefault();
        return string.IsNullOrEmpty(userInfo) ? default : JsonSerializer.Deserialize<T>(userInfo);
    }

    private IEnumerable<string>? GetClaimValueByType(string claimType)
    {
        return _httpContextAccessor.HttpContext?.User.Claims?.Where(item => item.Type == claimType)
            .Select(item => item.Value);
    }


    /// <inheritdoc />
    public Task<string> CreateTokenAsync<T, TKey>(T data) where T : Entity<TKey>
    {
        var claims = new[]
        {
            new Claim(Constant.Id, data.Id?.ToString() ?? string.Empty),
            new Claim(Constant.User, JsonSerializer.Serialize(data))
        };

        var cred = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOptions.SecretKey!)),
            SecurityAlgorithms.HmacSha256);

        var jwtSecurityToken = new JwtSecurityToken(
            _tokenOptions.Issuer, // 签发者
            _tokenOptions.Audience, // 接收者
            claims, // payload
            expires: DateTime.Now.AddMinutes(_tokenOptions.ExpireMinutes), // 过期时间
            signingCredentials: cred); // 令牌
        var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

        return Task.FromResult(token);
    }
}