using Microsoft.AspNetCore.Mvc;
using Simple.Auth.Application.Contract.Menus;

namespace Simple.Auth.HttpApi.Host.Controllers;

/// <summary>
/// 菜单
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class MenuController : ControllerBase
{
    private readonly IMenuService _menuService;

    public MenuController(IMenuService menuService)
    {
        _menuService = menuService;
    }

    /// <summary>
    /// 新增菜单
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task CreateAsync(CreateMenuDto input) =>
        await _menuService.CreateAsync(input);

    /// <summary>
    /// 删除菜单
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete]
    public async Task DeleteAsync(Guid id) =>
        await _menuService.DeleteAsync(id);

    /// <summary>
    /// 获取菜单树形数据结构
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet("menu-tree")]
    public async Task<IEnumerable<MenuTreeDto>> GetMenuTreeAsync([FromQuery] GetMenuInput input) =>
        await _menuService.GetMenuTreeAsync(input);

    /// <summary>
    /// 编辑菜单
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    [HttpPut]
    public async Task UpdateAsync(MenuDto dto) =>
        await _menuService.UpdateAsync(dto);
}