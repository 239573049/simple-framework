using EntityFrameworkCore.Core;
using Microsoft.EntityFrameworkCore;
using Simple.Auth.Domain.Menus;
using Token.Attributes;

namespace Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;

[ExposeServices(typeof(IMenuRepository))] // 指定注入服务
public class EfCoreMenuRepository : EfCoreRepository<AuthDbContext, Menu, Guid>, IMenuRepository
{
    public EfCoreMenuRepository(AuthDbContext dbContext) : base(dbContext)
    {
    }

    /// <inheritdoc />
    public async Task<List<Menu>> GetUserMenuAsync(string keywords, IEnumerable<Guid> roleIds)
    {
        var query =
            from menu in DbContext.Menu
            join menuRole in DbContext.MenuRole on menu.Id equals menuRole.MenuId
            where string.IsNullOrEmpty(keywords) || menu.Title.Contains(keywords) && roleIds.Contains(menuRole.RoleId)
            select menu;

        return await query.ToListAsync();
    }
}