using EntityFrameworkCore.Core;
using Simple.Admin.Domain.Users;

namespace Simple.Admin.EntityFrameworkCore;

public class UserInfoRepository : EfCoreRepository<SimpleDbContext, UserInfo, Guid>, IUserInfoRepository
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