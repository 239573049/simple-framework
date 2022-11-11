using AutoMapper;
using Simple.Admin.Application.Contract.User;
using Simple.Admin.Application.Contract.User.Views;
using Simple.Admin.Domain.Users;
using Simple.Application.Contract;
using Simple.Common.Jwt;
using System.Collections.Generic;
using System.Threading.Tasks;
using Token.Module.Dependencys;

namespace Simple.Admin.Application.User;

public class UserInfoService : IUserInfoService, ITransientDependency
{
    private readonly IUserInfoRepository _userInfoRepository;
    private readonly IMapper _mapper;
    private readonly CurrentManage _currentManage;

    public UserInfoService(IUserInfoRepository userInfoRepository, IMapper mapper, CurrentManage currentManage)
    {
        _userInfoRepository = userInfoRepository;
        _mapper = mapper;
        _currentManage = currentManage;
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
        var result = await _userInfoRepository.GetListAsync(input.Keywords, input.StartTime, input.EndTime, input.SkipCount, input.MaxResultCount);

        var count = await _userInfoRepository.GetCountAsync(input.Keywords, input.StartTime, input.EndTime);

        var dto = _mapper.Map<List<UserInfoDto>>(result);

        return new PagedResultDto<UserInfoDto>(count, dto);
    }

    public async Task<UserInfoDto> GetAsync()
    {
        var userInfo = await _userInfoRepository.FirstOrDefaultAsync(x => x.Id == _currentManage.GetUserId());

        var dto = _mapper.Map<UserInfoDto>(userInfo);

        return dto;
    }
}