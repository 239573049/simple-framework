using EntityFrameworkCore.Attributes;
using Microsoft.AspNetCore.Mvc;
using Simple.Application.Contract.Systems;
using Simple.Application.Contract.Systems.Dtos;

namespace Simple.HttpApi.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictionarySettingController : ControllerBase
    {
        private readonly IDictionarySettingService _dictionarySettingService;

        public DictionarySettingController(IDictionarySettingService dictionarySettingService)
        {
            _dictionarySettingService = dictionarySettingService;
        }

        /// <summary>
        /// 获取字典详情
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet("id")]
        [DisabledUnitOfWork]
        public async Task<DictionarySettingDto> GetAsync(Guid id)
            => await _dictionarySettingService.GetAsync(id);

        /// <summary>
        /// 获取字典详情
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet("key")]
        [DisabledUnitOfWork]
        public async Task<DictionarySettingDto> GetAsync(string key)
            => await _dictionarySettingService.GetAsync(key);

        /// <summary>
        /// 添加或编辑字典
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task SaveAsync(SaveAsyncDictionarySettingDto dto)
            => await _dictionarySettingService.SaveAsync(dto);
    }
}
