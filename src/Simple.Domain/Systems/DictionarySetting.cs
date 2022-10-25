using Simple.Domain.Base;
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

        public DictionarySettingType Type { get; set; }

        public DictionarySetting()
        {
            Value = new Dictionary<string, object>();
        }
    }
}
