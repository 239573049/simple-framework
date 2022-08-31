namespace Simple.Domain.Base;

public interface ITenant
{
    /// <summary>
    /// 租户Id
    /// </summary>
    Guid? TenantId { get; set; }
}