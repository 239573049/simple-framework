using Microsoft.AspNetCore.Mvc;
using Simple.Application.Contract.User;
using Simple.Application.Contract.User.Views;

namespace Simple.HttpApi.Host.Controllers;

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
    public async Task<List<UserInfoDto>> GetListAsync()
    {
        return await _userInfoService.GetListAsync();
    }
}