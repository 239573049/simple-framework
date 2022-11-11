using AutoMapper;
using Simple.Auth.Application.Contract.Menus;
using Simple.Auth.Domain.Menus;
using Simple.Common.Jwt;
using Token.Module.Dependencys;

namespace Simple.Auth.Application.Menus;

public class MenuService : IMenuService, ITransientDependency
{
    private readonly IMapper _mapper;
    private readonly IMenuRepository _menuRepository;
    private readonly CurrentManage _currentManage;

    public MenuService(IMapper mapper, IMenuRepository menuRepository, CurrentManage currentManage)
    {
        _mapper = mapper;
        _menuRepository = menuRepository;
        _currentManage = currentManage;
    }

    /// <inheritdoc />
    public async Task CreateAsync(CreateMenuDto input)
    {
        var data = _mapper.Map<Menu>(input);

        await _menuRepository.InsertAsync(data);
    }

    /// <inheritdoc />
    public async Task DeleteAsync(Guid id)
    {
        await _menuRepository.DeleteAsync(id);
    }

    /// <inheritdoc />
    public async Task<List<MenuTreeDto>> GetTreeAsync(GetMenuInput input)
    {
        var roleIds = _currentManage.GetRoles();


        var menus = await _menuRepository.GetUserMenuAsync(input.Keywords, roleIds);

        var tree = GetRecursionMenu(menus, null);

        return tree;
    }

    private List<MenuTreeDto> GetRecursionMenu(List<Menu> menus, Guid? parentId)
    {
        var trees = new List<MenuTreeDto>();

        var data = menus.Where(x => x.ParentId == parentId).OrderBy(x => x.Index);
        menus = menus.Where(x => x.ParentId != parentId).ToList();
        foreach (var d in data)
        {
            var tree = new MenuTreeDto()
            {
                ItemKey = d.Id,
                ParentId = d.ParentId,
                Component = d.Component,
                Icon = d.Icon,
                Index = d.Index,
                Path = d.Path,
                TenantId = d.TenantId,
                Text = d.Title
            };
            tree.Childrens.AddRange(GetRecursionMenu(menus, d.Id));
            trees.Add(tree);
        }

        return trees;
    }

    /// <inheritdoc />
    public async Task UpdateAsync(MenuDto dto)
    {
        var data = await _menuRepository.FirstAsync(x => x.Id == dto.Id);

        _mapper.Map(dto, data);

        await _menuRepository.UpdateAsync(data);
    }
}