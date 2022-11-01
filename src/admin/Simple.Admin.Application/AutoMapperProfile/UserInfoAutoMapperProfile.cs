using AutoMapper;
using Simple.Admin.Application.Contract.User.Views;
using Simple.Admin.Domain.Users;
using Simple.Shared;

namespace Simple.Admin.Application.AutoMapperProfile;

public class UserInfoAutoMapperProfile : Profile
{
    public UserInfoAutoMapperProfile()
    {
        CreateMap<CreateUserInfoDto, UserInfo>();
        CreateMap<UserInfoDto, UserInfo>();
        CreateMap<UserInfo,UserInfoDto>()
            .ForMember(options=>options.Status,options=>options.MapFrom(from=>from.Status.GetDescription()));
    }
}