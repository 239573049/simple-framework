using Simple.Domain.Base;

namespace Simple.Auth.Domain.Roles;

public interface ISimpleRoleRepository : IRepository<SimpleRole, Guid>
{
    
}