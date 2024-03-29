﻿using System.ComponentModel;

namespace Simple.Shared
{
    public enum UserInfoStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 0,

        /// <summary>
        /// 异常
        /// </summary>
        [Description("异常")]
        Forbidden = 1
    }
}