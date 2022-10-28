using EntityFrameworkCore.Shared.Base;
using Simple.Domain.Shared;

namespace Simple.Domain.Systems
{
    /// <summary>
    /// 字典设置
    /// </summary>
    public class DictionarySetting : AggregateRoot<Guid>
    {
        /// <summary>
        /// 字典Key
        /// </summary>
        public string Key { get; set; } = null!;

        public Dictionary<string, object> Value { get; set; }

        /// <summary>
        /// 设置类型
        /// </summary>
        public DictionarySettingType Type { get; set; }

        public DictionarySetting()
        {
            Value = new Dictionary<string, object>();
        }
    }
}
