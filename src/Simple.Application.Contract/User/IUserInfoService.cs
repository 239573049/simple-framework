using System.Threading.Tasks;
using Simple.Domain.Users;

namespace Simple.Application.Contract
{
    public interface IUserInfoService
    {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        Task<UserInfo> CreateAsync(UserInfo userInfo);
    }
}