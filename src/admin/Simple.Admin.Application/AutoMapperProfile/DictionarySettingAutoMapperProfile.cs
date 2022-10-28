using AutoMapper;
using Simple.Admin.Application.Contract.Systems.Dtos;
using Simple.Admin.Domain.Systems;

namespace Simple.Admin.Application.AutoMapperProfile
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
