using Microsoft.AspNetCore.Http;
using Simple.Admin.Domain.Shared;
using System.Security.Claims;
using System.Text.Json;
using Token.Module.Dependencys;

namespace Simple.Common.Jwt;

public class CurrentManage : ITransientDependency
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentManage(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
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

}