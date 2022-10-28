using System;

namespace Simple.Shared.Base
{

    public interface IHasCreationTime
    {
        /// <summary>创建时间</summary>
        DateTime CreationTime { get; set; }
    }
}