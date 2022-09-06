﻿using Simple.Domain.Base;

namespace Simple.Auth.Domain.Roles;

/// <summary>
/// 菜单角色配置
/// </summary>
public class MenuRole : Entity
{
    /// <summary>
    /// 关联菜单id
    /// </summary>
    public Guid MenuId { get; set; }

    /// <summary>
    /// 关联角色Id
    /// </summary>
    public Guid RoleId { get; set; }
}