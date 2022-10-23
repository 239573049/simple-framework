namespace Simple.Auth.Application.Contract.Menus;

public interface IMenuService
{
    /// <summary>
    /// 新增菜单
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task CreateAsync(CreateMenuDto input);

    /// <summary>
    /// 删除菜单
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id);

    /// <summary>
    /// 获取菜单树形数据结构
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<List<MenuTreeDto>> GetTreeAsync(GetMenuInput input);

    /// <summary>
    /// 编辑菜单
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    Task UpdateAsync(MenuDto dto);
}