namespace Simple.Common.Jwt;

public interface ITenantManager
{
    Guid? GetTenantId();
}