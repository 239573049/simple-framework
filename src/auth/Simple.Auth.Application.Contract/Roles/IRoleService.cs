namespace Simple.Auth.Application.Contract.Roles;

/// <summary>
/// 角色服务
/// </summary>
public interface IRoleService
{
    /// <summary>
    /// 新增角色
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    Task CreateAsync(CreateRoleDto dto);

    /// <summary>
    /// 删除角色
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id);

    /// <summary>
    /// 获取角色详情
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<SimpleRoleDto> GetAsync(Guid id);

    /// <summary>
    /// 获取角色列表
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<List<SimpleRoleDto>> GetListAsync(GetRoleInput input);
}