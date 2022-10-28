using EntityFrameworkCore.Shared.Base;
using System;

namespace Simple.Auth.Domain.Roles
{
    public class UserRoleFunction : Entity
    {
        /// <summary>
        /// 关联指定用户
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 关联指定角色
        /// </summary>
        public Guid RoleId { get; set; }
    }
}