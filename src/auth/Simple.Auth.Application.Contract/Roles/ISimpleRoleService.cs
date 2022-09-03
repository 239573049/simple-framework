namespace Simple.Auth.Application.Contract.Roles;

/// <summary>
/// 角色服务
/// </summary>
public interface ISimpleRoleService
{
    /// <summary>
    /// 新增角色
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    Task CreateRoleAsync(CreateRoleDto dto);

    /// <summary>
    /// 删除角色
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteRoleAsync(Guid id);

    /// <summary>
    /// 获取角色详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<SimpleRoleDto> GetRoleAsync(Guid id);

    /// <summary>
    /// 获取角色列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<List<SimpleRoleDto>> GetRoleListAsync(GetRoleInput input);
}