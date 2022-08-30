using Microsoft.AspNetCore.Mvc;
using Simple.Application.Contract;
using Simple.Domain.Users;

namespace Simple.HttpApi.Host.Controllers;

[ApiController]
[Route("[controller]")]
// [DisabledUnitOfWork]
public class UserInfoController : ControllerBase
{
    private readonly ILogger<UserInfoController> _logger;
    private readonly IUserInfoService _userInfoService;
    public UserInfoController(ILogger<UserInfoController> logger, IUserInfoService userInfoService)
    {
        _logger = logger;
        _userInfoService = userInfoService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(UserInfo userInfo)
    {
        var data = await _userInfoService.CreateAsync(userInfo);

        return new OkObjectResult(data);
    }
}