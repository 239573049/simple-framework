using Microsoft.EntityFrameworkCore;
using Simple.Auth.Domain.Menus;
using System.Collections.Generic;
using System;
using System.Linq;
using Simple.Admin.Domain.Users;
using Simple.Auth.Domain.Roles;
using System.Xml.Linq;
using Simple.Auth.Domain.Users;

namespace EntityFrameworkCore.DbMigrations.Extensions;

public static class DefaultDataExtension
{

    public static void ConfigureDefaultData(this ModelBuilder builder)
    {
        // 防止实体重复
        builder.Ignore<AuthUserInfo>();

        #region  用户默认数据

        var userInfo = new UserInfo(Guid.NewGuid(), "admin", "admin", "admin", "");

        builder.Entity<UserInfo>().HasData(userInfo);

        var role = new Role(Guid.NewGuid())
        {
            Code = "admin",
            CreationTime = DateTime.Now,
            Index = 1,
            Name = "admin",
            IsPrivate = true,
        };

        builder.Entity<Role>().HasData(role);

        var userRole = new UserRoleFunction(Guid.NewGuid(), userInfo.Id,role.Id);

        builder.Entity<UserRoleFunction>().HasData(userRole);

        #endregion


        #region 菜单默认数据

        var menus = new List<Menu>()
        {
            new (Guid.NewGuid(),"首页","HomeOutlined",0,"@/pages/admin/home","/",null,null),
            new (Guid.NewGuid(),"菜单管理","",1,"@/pages/admin/menu","/menu",null,null),
            new (Guid.NewGuid(),"字典设置","",1,"@/pages/admin/dictionary-settings","/dictionary-settings",null,null),
            new (Guid.NewGuid(),"用户管理","",1,"@/pages/admin/user","/user",null,null),
        };

        builder.Entity<Menu>().HasData(menus);

        // 添加角色默认菜单
        builder.Entity<MenuRoleFunction>().HasData(menus.Select(x => new MenuRoleFunction(Guid.NewGuid(), x.Id, role.Id)));

        #endregion
    }
}