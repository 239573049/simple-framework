using System.Collections.Generic;
using System.Threading.Tasks;
using Simple.Admin.Application.Contract.User.Views;

namespace Simple.Admin.Application.Contract.User;

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
    /// <returns></returns>
    Task<List<UserInfoDto>> GetListAsync();

}