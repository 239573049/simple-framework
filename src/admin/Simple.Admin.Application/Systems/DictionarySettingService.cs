using AutoMapper;
using Simple.Admin.Application.Contract.Systems;
using Simple.Admin.Application.Contract.Systems.Dtos;
using Simple.Admin.Domain.Systems;
using System;
using System.Threading.Tasks;
using Token.Module.Dependencys;
using Token.Module.Exceptions;

namespace Simple.Admin.Application.Systems
{
    public class DictionarySettingService : IDictionarySettingService, ITransientDependency
    {
        private readonly IDictionarySettingRepository _dictionarySettingRepository;
        private readonly IMapper _mapper;

        public DictionarySettingService(IDictionarySettingRepository dictionarySettingRepository, IMapper mapper)
        {
            _dictionarySettingRepository = dictionarySettingRepository;
            _mapper = mapper;
        }

        public async Task SaveAsync(SaveAsyncDictionarySettingDto dto)
        {
            var data = _mapper.Map<DictionarySetting>(dto);
            if (dto.Id != Guid.Empty)
            {
                var result = await _dictionarySettingRepository.FirstOrDefaultAsync(x => x.Id == dto.Id);
                if (result != null)
                {
                    result.Value = data.Value;
                    result.Key = dto.Key;
                    await _dictionarySettingRepository.UpdateAsync(result);
                    return;
                }
                throw new BusinessException("数据丢失", 404);
            }
            await _dictionarySettingRepository.InsertAsync(data);
        }

        public async Task<DictionarySettingDto> GetAsync(Guid id)
        {
            var data = await _dictionarySettingRepository.GetAsync(id);

            var dto = _mapper.Map<DictionarySettingDto>(data);

            return dto;
        }

        public async Task<DictionarySettingDto> GetAsync(string key)
        {
            var data = await _dictionarySettingRepository.FirstOrDefaultAsync(x => x.Key == key);

            var dto = _mapper.Map<DictionarySettingDto>(data);

            return dto;
        }
    }
}
