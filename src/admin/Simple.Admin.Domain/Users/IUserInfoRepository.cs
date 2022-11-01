using Simple.Shared.Base;

namespace Simple.Admin.Domain.Users;

public interface IUserInfoRepository : IRepository<UserInfo, Guid>
{
    Task<UserInfo> CreateAsync(UserInfo userInfo);

}