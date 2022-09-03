using Simple.Domain.Base;

namespace Simple.Auth.Domain.Menus;

public interface IMenuRepository : IRepository<Menu,Guid>
{
    /// <summary>
    /// 获取用户可访菜单
    /// </summary>
    /// <param name="id"></param>
    /// <param name="keywords"></param>
    /// <returns></returns>
    Task<List<Menu>> GetUserMenuAsync(Guid id,string? keywords);
}