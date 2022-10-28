using AutoMapper;
using Simple.Admin.Application.Contract.User.Views;
using Simple.Admin.Domain.Users;

namespace Simple.Admin.Application.AutoMapperProfile;

public class UserInfoAutoMapperProfile : Profile
{
    public UserInfoAutoMapperProfile()
    {
        CreateMap<CreateUserInfoDto, UserInfo>();
        CreateMap<UserInfoDto, UserInfo>().ReverseMap();
    }
}