using Simple.Domain.Shared;
using Simple.Shared;
using Simple.Shared.Base;
using System;

namespace Simple.Auth.Domain.Users
{
    public class AuthUserInfo : AggregateRoot<Guid>, IUserInfo<Guid>, ITenant
    {
        /// <summary>
        /// 昵称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 账号状态
        /// </summary>
        public UserInfoStatus Status { get; set; }

        public Guid? TenantId { get; set; }
    }
}
