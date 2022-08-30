using AutoMapper;
using Simple.Application.Contract.User.Views;
using Simple.Domain.Users;

namespace Simple.Application.AutoMapperProfile;

public class UserInfoAutoMapperProfile : Profile
{
    public UserInfoAutoMapperProfile()
    {
        CreateMap<CreateUserInfoDto, UserInfo>();
        CreateMap<UserInfoDto, UserInfo>().ReverseMap();
    }
}