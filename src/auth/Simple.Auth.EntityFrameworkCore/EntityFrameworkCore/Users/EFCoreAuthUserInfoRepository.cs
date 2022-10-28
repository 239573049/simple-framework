using EntityFrameworkCore.Core;
using Simple.Auth.Domain.Users;
using Token.Module.Attributes;

namespace Simple.Auth.EntityFrameworkCore.EntityFrameworkCore.Users;

[ExposeServices(typeof(IAuthUserInfoRepository))]
public class EFCoreAuthUserInfoRepository : EfCoreRepository<AuthDbContext, AuthUserInfo,Guid>, IAuthUserInfoRepository
{
    public EFCoreAuthUserInfoRepository(AuthDbContext dbContext) : base(dbContext)
    {
    }

}