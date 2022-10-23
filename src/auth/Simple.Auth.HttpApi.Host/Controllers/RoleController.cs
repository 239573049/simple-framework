﻿using Microsoft.AspNetCore.Mvc;
using Simple.Auth.Application.Contract.Roles;

namespace Simple.Auth.HttpApi.Host.Controllers;

/// <summary>
/// 角色
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class RoleController : ControllerBase
{
    private readonly IRoleService _simpleRoleService;

    public RoleController(IRoleService simpleRoleService)
    {
        _simpleRoleService = simpleRoleService;
    }

    /// <summary>
    /// 新增角色
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task CreateAsync(CreateRoleDto dto) =>
        await _simpleRoleService.CreateAsync(dto);

    /// <summary>
    /// 删除角色
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public async Task DeleteAsync(Guid id) =>
        await _simpleRoleService.DeleteAsync(id);

    /// <summary>
    /// 获取角色详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<SimpleRoleDto> GetAsync(Guid id) =>
        await _simpleRoleService.GetAsync(id);

    /// <summary>
    /// 获取角色列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet("list")]
    public async Task<List<SimpleRoleDto>> GetListAsync([FromQuery] GetRoleInput input) =>
        await _simpleRoleService.GetListAsync(input);
}