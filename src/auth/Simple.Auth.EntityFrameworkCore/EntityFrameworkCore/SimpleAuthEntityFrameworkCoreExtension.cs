using EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Simple.Auth.Domain.Menus;
using Simple.Auth.Domain.Roles;
using Simple.Auth.Domain.Users;

namespace Simple.Auth.EntityFrameworkCore.EntityFrameworkCore;

public static class SimpleAuthEntityFrameworkCoreExtension
{
    public static ModelBuilder ConfigureAuth(this ModelBuilder builder)
    {
        builder.Entity<Role>(x =>
        {
            x.ToTable("Roles", "角色");

            x.AddSimpleConfigure();

            x.Property(x => x.Code).HasComment("编号");
            x.Property(x => x.Index).HasComment("顺序");
            x.Property(x => x.Name).HasComment("角色名称");
            x.Property(x => x.IsPrivate).HasComment("是否私有 私有无法删除");
        });

        builder.Entity<UserRoleFunction>(x =>
        {
            x.ToTable("UserRoleFunctions", "用户角色配置");
            x.HasIndex(x => x.Id);
            x.HasKey(x => x.Id);

            x.Property(x => x.RoleId).HasComment("角色Id");
            x.Property(x => x.UserId).HasComment("用户id");
        });

        builder.Entity<MenuRoleFunction>(x =>
        {
            x.ToTable("MenuRoleFunctions", "菜单角色配置");
            x.HasIndex(x => x.Id);
            x.HasKey(x => x.Id);


            x.Property(x => x.MenuId).HasComment("菜单Id");
            x.Property(x => x.RoleId).HasComment("角色Id");

        });

        builder.Entity<Menu>(x =>
        {
            x.ToTable("Menus");

            x.AddSimpleConfigure();

            x.Property(x => x.Component).HasComment("前端对应组件");
            x.Property(x => x.Icon).HasComment("图标");
            x.Property(x => x.Path).HasComment("前端跳转路由");
            x.Property(x => x.Title).HasComment("菜单显示标题");
            x.Property(x => x.ParentId).HasComment("上级id 为null表示当前为顶层");
            x.Property(x => x.Index).HasComment("顺序");

        });

        builder.Entity<AuthUserInfo>(x =>
        {
            x.ToTable("UserInfos");

            x.AddSimpleConfigure();

        });


        return builder;
    }

}