using EfCoreEntityFrameworkCore.Core;
using Simple.Domain.Users;
using Token.Module.Attributes;
using Token.Module.Dependencys;

namespace Simple.EntityFrameworkCore;

[ExposeServices(typeof(IUserInfoRepository))]
public class EfCoreUserInfoRepository : Repository<SimpleDbContext, UserInfo, Guid>, IUserInfoRepository
{
    public EfCoreUserInfoRepository(SimpleDbContext dbContext) :
        base(dbContext)
    {
    }

    public async Task<UserInfo> CreateAsync(UserInfo userInfo)
    {
        var result = await DbSet.AddAsync(userInfo);

        return result.Entity;
    }
}