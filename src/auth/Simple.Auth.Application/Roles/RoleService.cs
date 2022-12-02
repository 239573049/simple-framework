using AutoMapper;
using Simple.Auth.Application.Contract.Roles;
using Simple.Auth.Domain.Roles;
using Token.Dependency;

namespace Simple.Auth.Application.Roles;

/// <inheritdoc />
public class RoleService : IRoleService, ITransientDependency
{
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;

    public RoleService(IRoleRepository roleRepository, IMapper mapper)
    {
        _roleRepository = roleRepository;
        _mapper = mapper;
    }


    /// <inheritdoc />
    public async Task CreateAsync(CreateRoleDto dto)
    {
        var data = _mapper.Map<Role>(dto);

        await _roleRepository.InsertAsync(data);
    }

    /// <inheritdoc />
    public async Task DeleteAsync(Guid id)
    {
        await _roleRepository.DeleteAsync(id);
    }

    /// <inheritdoc />
    public async Task<RoleDto> GetAsync(Guid id)
    {
        var result = await _roleRepository.FirstAsync(x => x.Id == id);

        var dto = _mapper.Map<RoleDto>(result);

        return dto;
    }

    /// <inheritdoc />
    public async Task<List<RoleDto>> GetListAsync(GetRoleInput input)
    {
        var roles = await _roleRepository.GetListAsync(x =>
            string.IsNullOrEmpty(input.Keywords) || x.Name.Contains(input.Keywords));

        var dto = _mapper.Map<List<RoleDto>>(roles);

        return dto;
    }
}