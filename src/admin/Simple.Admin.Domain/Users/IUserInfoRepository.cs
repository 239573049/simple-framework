using Simple.Shared.Base;

namespace Simple.Admin.Domain.Users;

public interface IUserInfoRepository : IRepository<UserInfo, Guid>
{
    Task<UserInfo> CreateAsync(UserInfo userInfo);

    Task<List<UserInfo>> GetListAsync(string? keywords, DateTime? startTime, DateTime? endTime, int skipCount, int maxResultCount);

    Task<int> GetCountAsync(string? keywords, DateTime? startTime, DateTime? endTime);
}