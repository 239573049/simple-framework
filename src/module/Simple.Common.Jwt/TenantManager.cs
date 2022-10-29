using Microsoft.AspNetCore.Http;
using Simple.Admin.Domain.Shared;
using Simple.Shared;
using Token.Module.Dependencys;

namespace Simple.Common.Jwt;

public class TenantManager : ITransientDependency
{
    private readonly IHttpContextAccessor _accessor;

    public TenantManager(IHttpContextAccessor accessor)
    {
        _accessor = accessor;
    }

    public Guid? GetTenantId()
    {
        var tenant = _accessor.HttpContext?.Request.Headers[Constant.TenantId].ToString();

        if (string.IsNullOrEmpty(tenant))
            return null;

        return Guid.Parse(tenant);
    }
}