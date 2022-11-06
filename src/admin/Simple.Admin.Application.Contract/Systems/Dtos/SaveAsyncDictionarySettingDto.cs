using System;
using System.Collections.Generic;
using Simple.Shared;

namespace Simple.Admin.Application.Contract.Systems.Dtos
{
    public class SaveAsyncDictionarySettingDto
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 字典Key
        /// </summary>
        public string Key { get; set; } = null!;

        public Dictionary<string, object> Value { get; set; }

        /// <summary>
        /// 设置类型
        /// </summary>
        public DictionarySettingType Type { get; set; }

        public SaveAsyncDictionarySettingDto()
        {
            Value = new Dictionary<string, object>();
        }
    }
}
