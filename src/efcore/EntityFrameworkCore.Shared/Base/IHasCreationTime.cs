using System;

namespace EntityFrameworkCore.Shared.Base
{

    public interface IHasCreationTime
    {
        /// <summary>创建时间</summary>
        DateTime CreationTime { get; set; }
    }
}