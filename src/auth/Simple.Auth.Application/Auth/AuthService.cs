using AutoMapper;
using Simple.Auth.Application.Contract.Auth;
using Simple.Auth.Application.Contract.Auth.Dtos;
using Simple.Auth.Domain.Users;
using Simple.Common.Infrastructure.Utils;
using Simple.Shared;
using Token.Dependency;

namespace Simple.Auth.Application.Auth;

/// <summary>
/// 授权
/// </summary>
public class AuthService : IAuthService, ITransientDependency
{
    private readonly IAuthUserInfoRepository _userInfoRepository;
    private readonly IMapper _mapper;

    public AuthService(IAuthUserInfoRepository userInfoRepository, IMapper mapper)
    {
        _userInfoRepository = userInfoRepository;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<AuthUserInfoDto> SignOnAsync(SignOnInput input)
    {
        var userInfo = await _userInfoRepository.GetAuthUserInfoAsync(input.Username, input.Password?.DesEncrypt());

        if (userInfo == null)
        {
            throw new BusinessException("账号密码错误");
        }

        var dto = _mapper.Map<AuthUserInfoDto>(userInfo);

        return dto;
    }
}