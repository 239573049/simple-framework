using EntityFrameworkCore.Core;
using EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Simple.Admin.Domain.Users;
using Token.Module.Helpers;

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

    public async Task<List<UserInfo>> GetListAsync(string keywords, DateTime? startTime, DateTime? endTime, int skipCount, int maxResultCount)
    {
        var query = CreateQuery(keywords, startTime, endTime);

        return await query.PageBy(skipCount, maxResultCount).ToListAsync();
    }

    public async Task<int> GetCountAsync(string keywords, DateTime? startTime, DateTime? endTime)
    {
        var query = CreateQuery(keywords, startTime, endTime);

        return await query.CountAsync();
    }

    private IQueryable<UserInfo> CreateQuery(string keywords, DateTime? startTime, DateTime? endTime)
    {
        var query =
            DbContext.UserInfo!
                .WhereIf(!keywords.IsNullOrEmpty(), x => x.Name != null && EF.Functions.Like(x!.Name, keywords))
                .WhereIf(startTime.HasValue, x => x.CreationTime >= startTime)
                .WhereIf(endTime.HasValue, x => x.CreationTime <= endTime);

        return query;
    }
}