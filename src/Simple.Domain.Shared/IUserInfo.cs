using Simple.Shared;
using Simple.Shared.Base;

namespace Simple.Domain.Shared
{
    /// <summary>
    /// 定义系统用户基础实体
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IUserInfo<out TKey> : IEntity<TKey>
    {
        /// <summary>
        /// 昵称
        /// </summary>
        string? Name { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        string? UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        string? PassWord { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        string? Avatar { get; set; }

        /// <summary>
        /// 账号状态
        /// </summary>
        UserInfoStatus Status { get; set; }
    }
}
