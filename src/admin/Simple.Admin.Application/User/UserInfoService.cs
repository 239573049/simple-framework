using AutoMapper;
using Simple.Admin.Application.Contract.User;
using Simple.Admin.Application.Contract.User.Views;
using Simple.Admin.Domain.Users;
using System.Collections.Generic;
using System.Threading.Tasks;
using Token.Module.Dependencys;

namespace Simple.Admin.Application.User;

public class UserInfoService : IUserInfoService, ITransientDependency
{
    private readonly IUserInfoRepository _userInfoRepository;
    private readonly IMapper _mapper;

    public UserInfoService(IUserInfoRepository userInfoRepository, IMapper mapper)
    {
        _userInfoRepository = userInfoRepository;
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateUserInfoDto userInfo)
    {
        var data = _mapper.Map<UserInfo>(userInfo);

        await _userInfoRepository.CreateAsync(data);
    }

    /// <param name="input"></param>
    /// <inheritdoc />
    public async Task<List<UserInfoDto>> GetListAsync(GetUserInfoInput input)
    {
        var result = await _userInfoRepository.GetListAsync(x => x.Name.Contains(input.Keywords));

        return _mapper.Map<List<UserInfoDto>>(result);
    }
}