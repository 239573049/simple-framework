using Microsoft.AspNetCore.Http;
using Simple.Shared;
using System.Security.Claims;
using System.Text.Json;
using Token.Dependency;

namespace Simple.Common.Jwt;

public class CurrentManager : ITransientDependency
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentManager(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public bool? IsAuthenticated()
    {
        return _httpContextAccessor.HttpContext?.User.Identity?.IsAuthenticated;
    }

    public Guid? UserId()
    {
        var id = GetClaimValueByType(Constant.Id)?.FirstOrDefault();
        return string.IsNullOrEmpty(id) ? default(Guid?) : Guid.Parse(id);
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

    /// <summary>
    /// 获取用户角色列表
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Guid> GetRoles()
    {
        return _httpContextAccessor.HttpContext!.User.Claims.Where(x => x.Type == Constant.RoleId).Select(x => Guid.Parse(x.Value));
    }
}