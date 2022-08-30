using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Simple.Domain.Base;
using Simple.Domain.Shared;
using Token.Module.Dependencys;

namespace Simple.Common.Jwt;

public class CurrentManage : ICurrentManage, ITransientDependency
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly TokenOptions _tokenOptions;

    public CurrentManage(IHttpContextAccessor httpContextAccessor, IOptions<TokenOptions> tokenOptions)
    {
        _httpContextAccessor = httpContextAccessor;
        _tokenOptions = tokenOptions.Value;
    }

    /// <inheritdoc />
    public Guid? GetTenantId()
    {
        // 获取租户Id
        var tenantId = _httpContextAccessor.HttpContext?.Request.Headers[Constant.TenantId].FirstOrDefault();

        if (string.IsNullOrEmpty(tenantId))
            return default;

        return Guid.Parse(tenantId);
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

    /// <inheritdoc />
    public T? UserInfo<T>()
    {
        var userInfo = GetClaimValueByType(Constant.User)?.FirstOrDefault();
        return string.IsNullOrEmpty(userInfo) ? default : JsonConvert.DeserializeObject<T>(userInfo);
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
            new Claim(Constant.User, JsonConvert.SerializeObject(data))
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