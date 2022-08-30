namespace Simple.Domain.Users;

public interface IUserInfoRepository
{
    Task<UserInfo> CreateAsync(UserInfo userInfo);
}