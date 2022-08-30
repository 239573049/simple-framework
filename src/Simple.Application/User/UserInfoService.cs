using System.Threading.Tasks;
using Simple.Application.Contract;
using Simple.Domain.Users;

namespace Simple.Application
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IUserInfoRepository _userInfoRepository;
        public UserInfoService(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }

        public async Task<UserInfo> CreateAsync(UserInfo userInfo)
        {
            return await _userInfoRepository.CreateAsync(userInfo);
        }
    }
}