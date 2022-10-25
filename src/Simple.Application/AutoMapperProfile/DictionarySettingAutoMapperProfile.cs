using AutoMapper;
using Simple.Application.Contract.Systems.Dtos;
using Simple.Domain.Systems;

namespace Simple.Application.AutoMapperProfile
{
    public class DictionarySettingAutoMapperProfile : Profile
    {
        public DictionarySettingAutoMapperProfile()
        {
            CreateMap<DictionarySettingDto, DictionarySetting>().ReverseMap();
            CreateMap<SaveAsyncDictionarySettingDto, DictionarySetting>().ReverseMap();
        }
    }
}
