using AutoMapper;
using Simple.Auth.Application.Contract.Menus;

namespace Simple.Auth.Application.AutoMapperProfile;

public class MenuMapperProfile : Profile
{
    public MenuMapperProfile()
    {
        CreateMap<CreateMenuDto, Menu>();
        CreateMap<Menu, MenuDto>();
        CreateMap<MenuDto, Menu>();
        CreateMap<Menu, MenuTreeDto>();
    }
}