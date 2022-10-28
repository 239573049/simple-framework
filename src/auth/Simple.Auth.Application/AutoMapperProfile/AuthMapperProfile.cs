using AutoMapper;
using Simple.Auth.Application.Contract.Auth.Dtos;
using Simple.Auth.Domain.Users;

namespace Simple.Auth.Application.AutoMapperProfile;

public class AuthMapperProfile : Profile
{
    public AuthMapperProfile()
    {
        CreateMap<AuthUserInfo, AuthUserInfoDto>().ReverseMap();
        CreateMap<AuthUserInfoView, AuthUserInfoDto>().ReverseMap();
    }
}