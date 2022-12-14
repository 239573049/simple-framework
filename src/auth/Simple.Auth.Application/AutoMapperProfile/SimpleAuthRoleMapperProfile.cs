using AutoMapper;
using Simple.Auth.Application.Contract.Roles;
using Simple.Auth.Domain.Roles;

namespace Simple.Auth.Application.AutoMapperProfile;

public class SimpleAuthRoleMapperProfile : Profile
{
    public SimpleAuthRoleMapperProfile()
    {
        CreateMap<CreateRoleDto, Role>();
        CreateMap<Role, RoleDto>();
    }
}