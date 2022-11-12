using Simple.Shared.Base;

namespace Simple.Admin.Domain.Systems
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

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        Task<List<DictionarySetting>> GetListAsync(string? keywords);
    }
}
