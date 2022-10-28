using System;

namespace Simple.Shared.Base
{
    public interface IModificationAuditedObject : IHasModificationTime
    {
        /// <summary>
        /// 最后一次更新人
        /// </summary>
        Guid? LastModifierId { get; set; }
    }
}