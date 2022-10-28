using Simple.Admin.Domain.Shared;
using Simple.Auth.Domain.Roles;
using Simple.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple.Auth.Domain.Users
{
    public class AuthUserInfoView : Entity<Guid>
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

        public IEnumerable<Role> Roles { get; set; }

        public AuthUserInfoView(Guid id) : base(id)
        {
            Roles = Enumerable.Empty<Role>();
        }

        protected AuthUserInfoView()
        {
            Roles = Enumerable.Empty<Role>();
        }
    }
}