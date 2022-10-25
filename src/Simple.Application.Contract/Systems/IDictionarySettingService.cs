using Simple.Application.Contract.Systems.Dtos;
using System;
using System.Threading.Tasks;

namespace Simple.Application.Contract.Systems
{
    public interface IDictionarySettingService
    {
        /// <summary>
        /// 获取字典设置详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<DictionarySettingDto> GetAsync(Guid id);

        /// <summary>
        /// 获取字典设置详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<DictionarySettingDto> GetAsync(string key);

        /// <summary>
        /// 保存字典设置
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task SaveAsync(SaveAsyncDictionarySettingDto dto);
    }
}
