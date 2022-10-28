using Simple.Shared.Base;
using System;

namespace Simple.Auth.Domain.Roles
{

    /// <summary>
    /// 菜单角色配置
    /// </summary>
    public class MenuRoleFunction : Entity
    {
        /// <summary>
        /// 关联菜单id
        /// </summary>
        public Guid MenuId { get; set; }

        /// <summary>
        /// 关联角色Id
        /// </summary>
        public Guid RoleId { get; set; }

        protected MenuRoleFunction()
        {

        }

        public MenuRoleFunction(Guid id, Guid menuId, Guid roleId) : base(id)
        {
            MenuId = menuId;
            RoleId = roleId;
        }
    }
}