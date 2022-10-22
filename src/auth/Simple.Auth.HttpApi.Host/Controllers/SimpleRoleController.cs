using Microsoft.AspNetCore.Mvc;
using Simple.Auth.Application.Contract.Roles;

namespace Simple.Auth.HttpApi.Host.Controllers;

/// <summary>
/// 角色
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class SimpleRoleController : ControllerBase
{
    private readonly ISimpleRoleService _simpleRoleService;

    public SimpleRoleController(ISimpleRoleService simpleRoleService)
    {
        _simpleRoleService = simpleRoleService;
    }

    /// <summary>
    /// 新增角色
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task CreateRoleAsync(CreateRoleDto dto) =>
        await _simpleRoleService.CreateRoleAsync(dto);

    /// <summary>
    /// 删除角色
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public async Task DeleteRoleAsync(Guid id) =>
        await _simpleRoleService.DeleteRoleAsync(id);

    /// <summary>
    /// 获取角色详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<SimpleRoleDto> GetRoleAsync(Guid id) =>
        await _simpleRoleService.GetRoleAsync(id);

    /// <summary>
    /// 获取角色列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet("list")]
    public async Task<List<SimpleRoleDto>> GetRoleListAsync([FromQuery] GetRoleInput input) =>
        await _simpleRoleService.GetRoleListAsync(input);
}