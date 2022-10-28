using Simple.Domain.Base;

namespace Simple.Domain.Systems
{
    public interface IDictionarySettingRepository : IRepository<DictionarySetting, Guid>
    {
        /// <summary>
        /// 获取详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<DictionarySetting> GetAsync(Guid id);

        /// <summary>
        /// 删除详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(Guid id);
    }
}
