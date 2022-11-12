using Simple.Shared;
using System;
using System.Collections.Generic;

namespace Simple.Admin.Application.Contract.Systems.Dtos
{
    public class DictionarySettingDto
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 字典Key
        /// </summary>
        public string Key { get; set; } = null!;

        public List<string> Value { get; set; }

        /// <summary>
        /// 设置类型
        /// </summary>
        public DictionarySettingType Type { get; set; }

        public DictionarySettingDto()
        {
            Value = new List<string>();
        }
    }
}
