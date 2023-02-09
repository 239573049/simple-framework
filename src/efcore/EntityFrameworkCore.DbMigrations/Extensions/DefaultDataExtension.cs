using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.DbMigrations.Extensions;

public static class DefaultDataExtension
{

    public static void ConfigureDefaultData(this ModelBuilder builder)
    {
        // // 防止实体重复
        // builder.Ignore<AuthUserInfo>();
        //
        // #region  用户默认数据
        //
        // var userInfo = new UserInfo(Guid.NewGuid(), "admin", "admin", "admin".DesEncrypt(), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg");
        //
        // builder.Entity<UserInfo>().HasData(userInfo);
        //
        // var role = new Role(Guid.NewGuid())
        // {
        //     Code = "admin",
        //     CreationTime = DateTime.Now,
        //     Index = 1,
        //     Name = "admin",
        //     IsPrivate = true,
        // };
        //
        //
        // var user = new Role(Guid.NewGuid())
        // {
        //     Code = "user",
        //     CreationTime = DateTime.Now,
        //     Index = 2,
        //     Name = "user",
        //     IsPrivate = true,
        // };
        //
        // builder.Entity<Role>().HasData(role, user);
        //
        // var testUsers = new List<UserInfo>();
        //
        // for (int i = 0; i < 20; i++)
        // {
        //     var testUser = new UserInfo(Guid.NewGuid(), "test" + i, "test" + i, ("test" + i).DesEncrypt(),
        //         "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg");
        //
        //     testUsers.Add(testUser);
        //
        //     builder.Entity<UserRoleFunction>().HasData(new UserRoleFunction(Guid.NewGuid(), testUser.Id, user.Id));
        // }
        //
        // builder.Entity<UserInfo>().HasData(testUsers);
        //
        // var userRole = new UserRoleFunction(Guid.NewGuid(), userInfo.Id, role.Id);
        //
        // builder.Entity<UserRoleFunction>().HasData(userRole);
        //
        // #endregion
        //
        //
        // #region 菜单默认数据
        //
        // var menus = new List<Menu>()
        // {
        //     new (Guid.NewGuid(),"首页","IconHome",0,"@/pages/admin/home","/",null,null),
        //     new (Guid.NewGuid(),"菜单管理","IconMenu",1,"@/pages/admin/menu","/menu",null,null),
        //     new (Guid.NewGuid(),"字典设置","IconArticle",2,"@/pages/admin/dictionary-settings","/dictionary-settings",null,null),
        //     new (Guid.NewGuid(),"用户管理","IconUser",3,"@/pages/admin/user","/user",null,null),
        // };
        //
        // builder.Entity<Menu>().HasData(menus);
        //
        // // 添加角色默认菜单
        // builder.Entity<MenuRoleFunction>().HasData(menus.Select(x => new MenuRoleFunction(Guid.NewGuid(), x.Id, role.Id)));
        //
        // #endregion
    }
}