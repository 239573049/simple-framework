using EntityFrameworkCore.Core;
using Microsoft.EntityFrameworkCore;
using Simple.Auth.Domain.Menus;
using Token.Module.Attributes;
using Token.Module.Dependencys;

namespace Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;

[ExposeServices(typeof(IMenuRepository))] // 指定注入服务
public class EfCoreMenuRepository : Repository<AuthDbContext, Menu, Guid>, IMenuRepository, ITransientDependency
{
    public EfCoreMenuRepository(AuthDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Menu>> GetUserMenuAsync(Guid id, string? keywords)
    {
        var query =
            from menu in DbContext.Menu
            join menuRole in DbContext.MenuRole on menu.Id equals menuRole.MenuId
            where string.IsNullOrEmpty(keywords) || menu.Title.Contains(keywords)
            select menu;

        return await query.ToListAsync();
    }
}