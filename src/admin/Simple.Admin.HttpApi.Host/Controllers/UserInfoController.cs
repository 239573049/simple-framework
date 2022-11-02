using EntityFrameworkCore.Attributes;
using Microsoft.AspNetCore.Authorization;
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
    private readonly ILogger<UserInfoController> _logger;
    private readonly IUserInfoService _userInfoService;
    public UserInfoController(ILogger<UserInfoController> logger, IUserInfoService userInfoService)
    {
        _logger = logger;
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
    public async Task<PagedResultDto<UserInfoDto>> GetListAsync([FromQuery]GetUserInfoInput input)
    {
        return await _userInfoService.GetListAsync(input);
    }
}