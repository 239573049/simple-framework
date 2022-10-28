using System;

namespace Simple.Shared.Base
{
    public interface ITenant
    {
        /// <summary>
        /// 租户Id
        /// </summary>
        Guid? TenantId { get; set; }
    }
}