using AutoMapper;
using Simple.Auth.Application.Contract.Roles;
using Simple.Auth.Domain.Roles;
using Token.Module.Dependencys;

namespace Simple.Auth.Application.Roles;

/// <inheritdoc />
public class SimpleRoleService : ISimpleRoleService, ITransientDependency
{
    private readonly ISimpleRoleRepository _simpleRoleRepository;
    private readonly IMapper _mapper;

    public SimpleRoleService(ISimpleRoleRepository simpleRoleRepository, IMapper mapper)
    {
        _simpleRoleRepository = simpleRoleRepository;
        _mapper = mapper;
    }


    /// <inheritdoc />
    public async Task CreateRoleAsync(CreateRoleDto dto)
    {
        var data = _mapper.Map<SimpleRole>(dto);

        await _simpleRoleRepository.InsertAsync(data);
    }

    /// <inheritdoc />
    public async Task DeleteRoleAsync(Guid id)
    {
        await _simpleRoleRepository.DeleteAsync(id);
    }

    public async Task<SimpleRoleDto> GetRoleAsync(Guid id)
    {
        var result = await _simpleRoleRepository.FirstAsync(x => x.Id == id);

        var dto = _mapper.Map<SimpleRoleDto>(result);

        return dto;
    }

    /// <inheritdoc />
    public async Task<List<SimpleRoleDto>> GetRoleListAsync(GetRoleInput input)
    {
        var roles =await _simpleRoleRepository.GetListAsync(x =>
            string.IsNullOrEmpty(input.Keywords) || x.Name.Contains(input.Keywords));

        var dto = _mapper.Map<List<SimpleRoleDto>>(roles);

        return dto;
    }
}