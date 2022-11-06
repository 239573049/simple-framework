using EntityFrameworkCore.Attributes;
using Microsoft.AspNetCore.Mvc;
using Simple.Admin.Application.Contract.User;
using Simple.Admin.Application.Contract.User.Views;
using Simple.Application.Contract;

namespace Simple.Admin.HttpApi.Host.Controllers;

/// <summary>
/// 用户模块
/// </summary>
[ApiController]
[Route("api/[controller]")]

public class UserInfoController : ControllerBase
{
    private readonly IUserInfoService _userInfoService;
    public UserInfoController(IUserInfoService userInfoService)
    {
        _userInfoService = userInfoService;
    }

    /// <summary>
    /// 创建用户
    /// </summary>
    /// <param name="userInfo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateUserInfoDto userInfo)
    {
        await _userInfoService.CreateAsync(userInfo);

        return new OkResult();
    }

    /// <summary>
    /// 获取所有用户
    /// </summary>
    /// <returns></returns>
    [HttpGet("list")]
    [DisabledUnitOfWork]
    public async Task<PagedResultDto<UserInfoDto>> GetListAsync([FromQuery] GetUserInfoInput input)
    {
        return await _userInfoService.GetListAsync(input);
    }

    /// <summary>
    /// 获取用户详情
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [DisabledUnitOfWork]
    public async Task<UserInfoDto> GetAsync()
    {
        return await _userInfoService.GetAsync();
    }
}