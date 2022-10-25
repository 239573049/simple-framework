using EntityFrameworkCore.Core;
using Simple.Domain.Users;
using Token.Module.Dependencys;

namespace Simple.EntityFrameworkCore;

public class UserInfoRepository : EfCoreRepository<SimpleDbContext, UserInfo, Guid>, IUserInfoRepository, ITransientDependency
{
    public UserInfoRepository(SimpleDbContext dbContext) :
        base(dbContext)
    {
    }

    public async Task<UserInfo> CreateAsync(UserInfo userInfo)
    {
        var result = await DbSet.AddAsync(userInfo);

        return result.Entity;
    }
}