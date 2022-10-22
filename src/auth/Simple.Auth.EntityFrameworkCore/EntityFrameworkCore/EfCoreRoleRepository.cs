using EntityFrameworkCore.Core;
using Simple.Auth.Domain.Roles;
using Token.Module.Attributes;
using Token.Module.Dependencys;

namespace Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;

[ExposeServices(typeof(IRoleRepository))] // 指定注入服务
public class EfCoreRoleRepository : Repository<AuthDbContext, Role, Guid>, IRoleRepository ,ITransientDependency
{
    public EfCoreRoleRepository(AuthDbContext dbContext) : base(dbContext)
    {
    }
    
    
}