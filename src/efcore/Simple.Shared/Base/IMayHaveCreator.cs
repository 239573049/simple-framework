using System;

namespace Simple.Shared.Base
{
    public interface IMayHaveCreator
    {
        /// <summary>
        /// 创建人
        /// </summary>
        Guid? CreatorId { get; set; }
    }
}