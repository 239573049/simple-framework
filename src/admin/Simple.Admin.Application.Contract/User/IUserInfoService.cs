using Simple.Admin.Application.Contract.User.Views;
using Simple.Application.Contract;

namespace Simple.Admin.Application.Contract.User
{

    public interface IUserInfoService
    {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        Task CreateAsync(CreateUserInfoDto userInfo);

        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<UserInfoDto>> GetListAsync(GetUserInfoInput input);

        /// <summary>
        /// 获取当前用户信息详情
        /// </summary>
        /// <returns></returns>
        Task<UserInfoDto> GetAsync();
    }
}