namespace Simple.Domain.Base;

public interface ITenant
{
    /// <summary>
    /// 租户Id
    /// </summary>
    public Guid? TenantId { get; set; }
}