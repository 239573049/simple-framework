﻿using System;
using System.Threading.Tasks;
using Simple.Admin.Application.Contract.Systems.Dtos;

namespace Simple.Admin.Application.Contract.Systems
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