using System;
using System.Threading.Tasks;
using Simple.Shared.Base;

namespace Simple.Auth.Domain.Users
{
    public interface IAuthUserInfoRepository : IRepository<AuthUserInfo, Guid>
    {
        /// <summary>
        /// 通过用户名 密码获取用户基本信息
        /// 包括用户角色信息
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<AuthUserInfoView> GetAuthUserInfoAsync(string username,string password);
    }
}