using EntityFrameworkCore.Core;
using Simple.Auth.Domain.Roles;
using Token.Module.Attributes;

namespace Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;

[ExposeServices(typeof(ISimpleRoleRepository))] // 指定注入服务
public class EfCoreSimpleRoleRepository : Repository<AuthDbContext, SimpleRole, Guid>, ISimpleRoleRepository
{
    public EfCoreSimpleRoleRepository(AuthDbContext dbContext) : base(dbContext)
    {
    }
    
    
}