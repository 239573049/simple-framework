using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DictionarySettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeleteCreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictionarySettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuRoleFunctions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "菜单Id"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "角色Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRoleFunctions", x => x.Id);
                },
                comment: "菜单角色配置");

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "菜单显示标题"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "图标"),
                    Index = table.Column<int>(type: "int", nullable: false, comment: "顺序"),
                    Component = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "前端对应组件"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "前端跳转路由"),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "上级id 为null表示当前为顶层"),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeleteCreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "角色名称"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "编号"),
                    Index = table.Column<int>(type: "int", nullable: false, comment: "顺序"),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false, comment: "是否私有 私有无法删除"),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeleteCreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                },
                comment: "角色");

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeleteCreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleFunctions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "用户id"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "角色Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleFunctions", x => x.Id);
                },
                comment: "用户角色配置");

            migrationBuilder.InsertData(
                table: "MenuRoleFunctions",
                columns: new[] { "Id", "MenuId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("2c11ceff-2002-467c-9ceb-21e81517522a"), new Guid("370be57a-ed43-4e0f-8a3c-78e02483b42c"), new Guid("4cdc12d4-5060-439f-9024-525011efaf81") },
                    { new Guid("38153075-8c3d-4363-9640-b881c59d2eb4"), new Guid("760f0579-ec52-4375-8fa3-17a14aef3dce"), new Guid("4cdc12d4-5060-439f-9024-525011efaf81") },
                    { new Guid("c70d3608-cd77-4844-9999-9054c2cae7f2"), new Guid("82c0045b-1f29-4b28-904c-9c1eccd589fb"), new Guid("4cdc12d4-5060-439f-9024-525011efaf81") },
                    { new Guid("fafe0e71-6252-4fa7-984b-e7e31330d80c"), new Guid("f7ee403f-f8b9-4d8f-b30e-b2a9c7e514d3"), new Guid("4cdc12d4-5060-439f-9024-525011efaf81") }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "Icon", "Index", "IsDeleted", "LastModificationTime", "LastModifierId", "ParentId", "Path", "TenantId", "Title" },
                values: new object[,]
                {
                    { new Guid("370be57a-ed43-4e0f-8a3c-78e02483b42c"), "@/pages/admin/menu", "d0d5a3da23d8478f9f96bd5346667b8a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "", 1, false, null, null, null, "/menu", null, "菜单管理" },
                    { new Guid("760f0579-ec52-4375-8fa3-17a14aef3dce"), "@/pages/admin/home", "a46496bf08f34c09b7d6937e00ffc591", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "HomeOutlined", 0, false, null, null, null, "/", null, "首页" },
                    { new Guid("82c0045b-1f29-4b28-904c-9c1eccd589fb"), "@/pages/admin/dictionary-settings", "026d9e80a205415280d50a5efec97f5e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "", 1, false, null, null, null, "/dictionary-settings", null, "字典设置" },
                    { new Guid("f7ee403f-f8b9-4d8f-b30e-b2a9c7e514d3"), "@/pages/admin/user", "b94886e593d847f88b3ed1778a64bc66", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "", 1, false, null, null, null, "/user", null, "用户管理" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "Index", "IsDeleted", "IsPrivate", "LastModificationTime", "LastModifierId", "Name", "TenantId" },
                values: new object[] { new Guid("4cdc12d4-5060-439f-9024-525011efaf81"), "admin", "3e63d4465afc4519ab4f58c4f8efe37c", new DateTime(2022, 10, 30, 1, 31, 36, 237, DateTimeKind.Local).AddTicks(9714), null, null, null, "{}", 1, false, true, null, null, "admin", null });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Avatar", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Name", "PassWord", "Status", "TenantId", "UserName" },
                values: new object[] { new Guid("c8dfc2ee-e470-4b35-a2d3-45ee427589e2"), "", "728c53d65d974c7980241555e548f9c3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "admin", "admin", 0, null, "admin" });

            migrationBuilder.InsertData(
                table: "UserRoleFunctions",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[] { new Guid("6304e824-2e15-4ff8-bd5f-2fc548bee67c"), new Guid("4cdc12d4-5060-439f-9024-525011efaf81"), new Guid("c8dfc2ee-e470-4b35-a2d3-45ee427589e2") });

            migrationBuilder.CreateIndex(
                name: "IX_DictionarySettings_Id",
                table: "DictionarySettings",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DictionarySettings_Key",
                table: "DictionarySettings",
                column: "Key");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRoleFunctions_Id",
                table: "MenuRoleFunctions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_Id",
                table: "Menus",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Id",
                table: "Roles",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_Id",
                table: "UserInfos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleFunctions_Id",
                table: "UserRoleFunctions",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DictionarySettings");

            migrationBuilder.DropTable(
                name: "MenuRoleFunctions");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "UserRoleFunctions");
        }
    }
}
