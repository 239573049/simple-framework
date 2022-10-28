using EntityFrameworkCore.Shared.Base;

namespace Simple.Domain.Users;

public interface IUserInfoRepository : IRepository<UserInfo, Guid>
{
    Task<UserInfo> CreateAsync(UserInfo userInfo);
}