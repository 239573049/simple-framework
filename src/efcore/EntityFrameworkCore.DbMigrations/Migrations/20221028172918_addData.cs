using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("2885593e-298b-4bd9-8efc-08740ee0adb0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f1a96082-0bb3-4bad-ae87-3573f24e599e"));

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("b64d9277-2716-4dc9-9c66-18311c3363ca"));

            migrationBuilder.InsertData(
                table: "MenuRoleFunctions",
                columns: new[] { "Id", "MenuId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("61a8b6ee-00b4-417e-b2ce-2ead942872e9"), new Guid("dd20c59b-ec18-4e89-b70e-39cd995f8f18"), new Guid("0d0c305d-fdfb-435b-a65a-868ffb74d6e5") },
                    { new Guid("7a3040ee-6105-470a-802f-d2bcb6596a5d"), new Guid("c7742972-6851-4bbc-ad35-ada1f39d2077"), new Guid("0d0c305d-fdfb-435b-a65a-868ffb74d6e5") },
                    { new Guid("7ea91342-524e-4fd6-99bc-005b8dcf30c9"), new Guid("b37c4c37-8b27-4935-a89d-78c2cf6252dd"), new Guid("0d0c305d-fdfb-435b-a65a-868ffb74d6e5") },
                    { new Guid("91dab773-31bc-4d9a-a028-16a5562bc69b"), new Guid("7f0eab34-78b7-47d0-9596-9de9d3e38510"), new Guid("0d0c305d-fdfb-435b-a65a-868ffb74d6e5") }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "Icon", "Index", "IsDeleted", "LastModificationTime", "LastModifierId", "ParentId", "Path", "TenantId", "Title" },
                values: new object[,]
                {
                    { new Guid("7f0eab34-78b7-47d0-9596-9de9d3e38510"), "@/pages/admin/dictionary-settings", "78bde32630cd4c6eac6775a8bdc0fe35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "", 1, false, null, null, null, "/dictionary-settings", null, "字典设置" },
                    { new Guid("b37c4c37-8b27-4935-a89d-78c2cf6252dd"), "@/pages/admin/home", "3d07abde59964c2fa072e23fb596aab0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "HomeOutlined", 0, false, null, null, null, "/", null, "首页" },
                    { new Guid("c7742972-6851-4bbc-ad35-ada1f39d2077"), "@/pages/admin/user", "6c559b82b1ea48418c400951db091093", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "", 1, false, null, null, null, "/user", null, "用户管理" },
                    { new Guid("dd20c59b-ec18-4e89-b70e-39cd995f8f18"), "@/pages/admin/menu", "8a18de374f2d4904b093883982386241", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "", 1, false, null, null, null, "/menu", null, "菜单管理" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "Index", "IsDeleted", "IsPrivate", "LastModificationTime", "LastModifierId", "Name", "TenantId" },
                values: new object[] { new Guid("0d0c305d-fdfb-435b-a65a-868ffb74d6e5"), "admin", "e04ba189ed804c008d5c2bea8ce56a04", new DateTime(2022, 10, 29, 1, 29, 17, 597, DateTimeKind.Local).AddTicks(9189), null, null, null, "{}", 1, false, true, null, null, "admin", null });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Avatar", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Name", "PassWord", "Status", "TenantId", "UserName" },
                values: new object[] { new Guid("ef4c4a34-f531-46e2-985d-04f8f2915f79"), "", "3372412b3ca3477fa6596e576fc37c47", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "admin", "admin", 0, null, "admin" });

            migrationBuilder.InsertData(
                table: "UserRoleFunctions",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[] { new Guid("84faf69a-b8dc-4f86-9655-4b34ade3cd73"), new Guid("0d0c305d-fdfb-435b-a65a-868ffb74d6e5"), new Guid("ef4c4a34-f531-46e2-985d-04f8f2915f79") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("61a8b6ee-00b4-417e-b2ce-2ead942872e9"));

            migrationBuilder.DeleteData(
                table: "MenuRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("7a3040ee-6105-470a-802f-d2bcb6596a5d"));

            migrationBuilder.DeleteData(
                table: "MenuRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("7ea91342-524e-4fd6-99bc-005b8dcf30c9"));

            migrationBuilder.DeleteData(
                table: "MenuRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("91dab773-31bc-4d9a-a028-16a5562bc69b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7f0eab34-78b7-47d0-9596-9de9d3e38510"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b37c4c37-8b27-4935-a89d-78c2cf6252dd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("c7742972-6851-4bbc-ad35-ada1f39d2077"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("dd20c59b-ec18-4e89-b70e-39cd995f8f18"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0d0c305d-fdfb-435b-a65a-868ffb74d6e5"));

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("ef4c4a34-f531-46e2-985d-04f8f2915f79"));

            migrationBuilder.DeleteData(
                table: "UserRoleFunctions",
                keyColumn: "Id",
                keyValue: new Guid("84faf69a-b8dc-4f86-9655-4b34ade3cd73"));

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "Icon", "Index", "IsDeleted", "LastModificationTime", "LastModifierId", "ParentId", "Path", "TenantId", "Title" },
                values: new object[] { new Guid("2885593e-298b-4bd9-8efc-08740ee0adb0"), "@/pages/user-admin/index", "b01dab58767945a3916233780bd017ff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "", 1, false, null, null, null, "/user-admin", null, "用户管理" });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "Icon", "Index", "IsDeleted", "LastModificationTime", "LastModifierId", "ParentId", "Path", "TenantId", "Title" },
                values: new object[] { new Guid("f1a96082-0bb3-4bad-ae87-3573f24e599e"), "@/pages/home/index", "598d073a580e4c74ae1d9f3d65c17bf3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "HomeOutlined", 0, false, null, null, null, "/home", null, "首页" });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Avatar", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Name", "PassWord", "Status", "TenantId", "UserName" },
                values: new object[] { new Guid("b64d9277-2716-4dc9-9c66-18311c3363ca"), "", "7fc7ae11ee3d44f7a4e5b7b17c453457", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "admin", "admin", 0, null, "admin" });
        }
    }
}
