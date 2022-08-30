using EfCoreEntityFrameworkCore.Core;
using Simple.Domain.Users;

namespace Simple.EntityFrameworkCore;

public class EfCoreUserInfoRepository : Repository<SimpleDbContext, UserInfo, Guid>, IUserInfoRepository
{
    public EfCoreUserInfoRepository(SimpleDbContext dbContext) :
        base(dbContext)
    {
    }

    public async Task<UserInfo> CreateAsync(UserInfo userInfo)
    {
        var result = await _dbSet.AddAsync(userInfo);

        return result.Entity;
    }
}