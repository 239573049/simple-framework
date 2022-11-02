using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class addUserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("2c11ceff-2002-467c-9ceb-21e81517522a"));

            migrationBuilder.DeleteData(
                table: "MenuRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("38153075-8c3d-4363-9640-b881c59d2eb4"));

            migrationBuilder.DeleteData(
                table: "MenuRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("c70d3608-cd77-4844-9999-9054c2cae7f2"));

            migrationBuilder.DeleteData(
                table: "MenuRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("fafe0e71-6252-4fa7-984b-e7e31330d80c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("370be57a-ed43-4e0f-8a3c-78e02483b42c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("760f0579-ec52-4375-8fa3-17a14aef3dce"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("82c0045b-1f29-4b28-904c-9c1eccd589fb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f7ee403f-f8b9-4d8f-b30e-b2a9c7e514d3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4cdc12d4-5060-439f-9024-525011efaf81"));

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("c8dfc2ee-e470-4b35-a2d3-45ee427589e2"));

            migrationBuilder.DeleteData(
                table: "UserRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("6304e824-2e15-4ff8-bd5f-2fc548bee67c"));

            migrationBuilder.InsertData(
                table: "MenuRoleFunctions",
                columns: new[] { "Id", "MenuId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("1e489ee0-06eb-4c36-92eb-69a6df34976d"), new Guid("fd54905e-662e-4b10-b8d7-381cc9ca7579"), new Guid("c7bbc045-1263-433e-b4d5-7c424c893bd8") },
                    { new Guid("32cbb4e1-9fb2-4c87-a982-b18d52865046"), new Guid("a6ff0958-c6f1-4044-887b-ec48ae39088c"), new Guid("c7bbc045-1263-433e-b4d5-7c424c893bd8") },
                    { new Guid("5046129e-9f8a-46fe-aae9-b5b77d1584e2"), new Guid("8926f9eb-fb6d-4dd3-88d7-6a748e9ae966"), new Guid("c7bbc045-1263-433e-b4d5-7c424c893bd8") },
                    { new Guid("cc6e39fc-601d-4f83-9f04-79fb8536bd22"), new Guid("6f84ae8a-5fad-43c7-8475-54d67796f62e"), new Guid("c7bbc045-1263-433e-b4d5-7c424c893bd8") }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "Icon", "Index", "IsDeleted", "LastModificationTime", "LastModifierId", "ParentId", "Path", "TenantId", "Title" },
                values: new object[,]
                {
                    { new Guid("6f84ae8a-5fad-43c7-8475-54d67796f62e"), "@/pages/admin/user", "5327c1fa433244c9834643f566695f03", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "IconUser", 3, false, null, null, null, "/user", null, "用户管理" },
                    { new Guid("8926f9eb-fb6d-4dd3-88d7-6a748e9ae966"), "@/pages/admin/home", "2b448b5679ac4b018c5d933ad49ac766", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "IconHome", 0, false, null, null, null, "/", null, "首页" },
                    { new Guid("a6ff0958-c6f1-4044-887b-ec48ae39088c"), "@/pages/admin/menu", "852fc87e16a349eda405b166946c3f30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "IconMenu", 1, false, null, null, null, "/menu", null, "菜单管理" },
                    { new Guid("fd54905e-662e-4b10-b8d7-381cc9ca7579"), "@/pages/admin/dictionary-settings", "0687aeab84f44bc5b55ff969f946b55a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "IconArticle", 2, false, null, null, null, "/dictionary-settings", null, "字典设置" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "Index", "IsDeleted", "IsPrivate", "LastModificationTime", "LastModifierId", "Name", "TenantId" },
                values: new object[] { new Guid("c7bbc045-1263-433e-b4d5-7c424c893bd8"), "admin", "e478053fc4ae45f8a3bdec4f17120385", new DateTime(2022, 11, 3, 1, 4, 7, 386, DateTimeKind.Local).AddTicks(7167), null, null, null, "{}", 1, false, true, null, null, "admin", null });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Avatar", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Name", "PassWord", "Status", "TenantId", "UserName" },
                values: new object[] { new Guid("21c7f47f-dbd3-41ba-a81d-1bf25033835d"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "2cae7d7877f349258f6072fddd0c45d9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "admin", "admin", 0, null, "admin" });

            migrationBuilder.InsertData(
                table: "UserRoleFunctions",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[] { new Guid("f21876bf-c745-4e70-8537-79bbd2099bcb"), new Guid("c7bbc045-1263-433e-b4d5-7c424c893bd8"), new Guid("21c7f47f-dbd3-41ba-a81d-1bf25033835d") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("1e489ee0-06eb-4c36-92eb-69a6df34976d"));

            migrationBuilder.DeleteData(
                table: "MenuRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("32cbb4e1-9fb2-4c87-a982-b18d52865046"));

            migrationBuilder.DeleteData(
                table: "MenuRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("5046129e-9f8a-46fe-aae9-b5b77d1584e2"));

            migrationBuilder.DeleteData(
                table: "MenuRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("cc6e39fc-601d-4f83-9f04-79fb8536bd22"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6f84ae8a-5fad-43c7-8475-54d67796f62e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8926f9eb-fb6d-4dd3-88d7-6a748e9ae966"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("a6ff0958-c6f1-4044-887b-ec48ae39088c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("fd54905e-662e-4b10-b8d7-381cc9ca7579"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c7bbc045-1263-433e-b4d5-7c424c893bd8"));

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("21c7f47f-dbd3-41ba-a81d-1bf25033835d"));

            migrationBuilder.DeleteData(
                table: "UserRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("f21876bf-c745-4e70-8537-79bbd2099bcb"));

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
        }
    }
}
