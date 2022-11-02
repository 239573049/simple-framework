using AutoMapper;
using Simple.Admin.Application.Contract.User;
using Simple.Admin.Application.Contract.User.Views;
using Simple.Admin.Domain.Users;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Simple.Application.Contract;
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
    public async Task<PagedResultDto<UserInfoDto>> GetListAsync(GetUserInfoInput input)
    {
        var result = await _userInfoRepository.GetListAsync(input.Keywords,input.StartTime,input.EndTime,input.SkipCount,input.MaxResultCount);
        
        var count = await _userInfoRepository.GetCountAsync(input.Keywords,input.StartTime,input.EndTime);

        var dto = _mapper.Map<List<UserInfoDto>>(result);

        return new PagedResultDto<UserInfoDto>(count, dto);
    }
}