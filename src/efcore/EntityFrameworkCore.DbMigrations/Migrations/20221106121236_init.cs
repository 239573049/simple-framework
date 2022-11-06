using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class init : Migration
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
                    { new Guid("01b9b35a-245b-47c6-9f4b-2a32a6ad1e8b"), new Guid("750d1d79-7ac6-4115-aae6-9c6cebcb59c7"), new Guid("c84cf25e-1aa3-43e2-be90-ae6c42b5af7b") },
                    { new Guid("9338ce22-9508-4a3f-b850-cdfb9ef71e7c"), new Guid("61fd1f15-b1b9-4360-96e2-b15fdd6a9c0c"), new Guid("c84cf25e-1aa3-43e2-be90-ae6c42b5af7b") },
                    { new Guid("b4afad7e-0732-4486-90c8-24ebed7ed7cf"), new Guid("d1e27f9f-23bf-4481-b9a5-f6d8ddee01d9"), new Guid("c84cf25e-1aa3-43e2-be90-ae6c42b5af7b") },
                    { new Guid("eb0c8349-f5ea-49e7-a8d0-74e83d09d5ae"), new Guid("0cd91965-9056-4e90-bd05-df27a125026f"), new Guid("c84cf25e-1aa3-43e2-be90-ae6c42b5af7b") }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "Icon", "Index", "IsDeleted", "LastModificationTime", "LastModifierId", "ParentId", "Path", "TenantId", "Title" },
                values: new object[,]
                {
                    { new Guid("0cd91965-9056-4e90-bd05-df27a125026f"), "@/pages/admin/menu", "64d60ff804be40efa04679ce97e1f2fd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "IconMenu", 1, false, null, null, null, "/menu", null, "菜单管理" },
                    { new Guid("61fd1f15-b1b9-4360-96e2-b15fdd6a9c0c"), "@/pages/admin/dictionary-settings", "976a1200eeb34d7796e56d9ecf5b7f01", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "IconArticle", 2, false, null, null, null, "/dictionary-settings", null, "字典设置" },
                    { new Guid("750d1d79-7ac6-4115-aae6-9c6cebcb59c7"), "@/pages/admin/user", "589ac2acf92949c29178f65eb378f297", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "IconUser", 3, false, null, null, null, "/user", null, "用户管理" },
                    { new Guid("d1e27f9f-23bf-4481-b9a5-f6d8ddee01d9"), "@/pages/admin/home", "1767872be6b8422b9ce42c81eedaa03a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", "IconHome", 0, false, null, null, null, "/", null, "首页" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "Index", "IsDeleted", "IsPrivate", "LastModificationTime", "LastModifierId", "Name", "TenantId" },
                values: new object[,]
                {
                    { new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), "user", "43232c0d21054de09d3a885a665d883e", new DateTime(2022, 11, 6, 20, 12, 36, 450, DateTimeKind.Local).AddTicks(1563), null, null, null, "{}", 2, false, true, null, null, "user", null },
                    { new Guid("c84cf25e-1aa3-43e2-be90-ae6c42b5af7b"), "admin", "52c7c25d0dee4802a1d2f4614bd4b4c3", new DateTime(2022, 11, 6, 20, 12, 36, 450, DateTimeKind.Local).AddTicks(1543), null, null, null, "{}", 1, false, true, null, null, "admin", null }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Avatar", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeleteCreatorId", "DeleteTime", "ExtraProperties", "IsDeleted", "LastModificationTime", "LastModifierId", "Name", "PassWord", "Status", "TenantId", "UserName" },
                values: new object[,]
                {
                    { new Guid("15309642-a2f6-4995-9949-20b7f95cb9d3"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "e6330a2b9ab84f16a2787d5fd87464d7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test0", "B04A038088748D19", 0, null, "test0" },
                    { new Guid("358acf33-b225-4004-a077-eaa82ba2cc81"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "260d567098f6428cb8245051f1931ca8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test9", "7B73D594C5AF69EB", 0, null, "test9" },
                    { new Guid("4be38eae-4bc2-418c-8477-0eb340897660"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "44240aa0ac394d2c997c4e7ef7c099fa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test15", "A8283C23A894B3DB", 0, null, "test15" },
                    { new Guid("52cfff8a-3f7f-4d3b-a3a4-4ddacfb073a7"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "61ac8363905044d091f951de95335fb6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "admin", "A279CD9A3FA16B2E", 0, null, "admin" },
                    { new Guid("5bca363e-6e8d-4995-bd43-14231521f4da"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "34b48ea750dd4800b1370dc5de1d1e3a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test1", "8C10BEE192CBEED3", 0, null, "test1" },
                    { new Guid("64eb7b10-9a8d-4e63-803f-9f9244a21c0b"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "892078810e894ab1a9eabe90087b65cc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test6", "469E814C186DC646", 0, null, "test6" },
                    { new Guid("659777bd-35d6-4efc-866b-172609439f9d"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "07540b3457ba4f8488456577f750b281", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test3", "B0531A6647D5B767", 0, null, "test3" },
                    { new Guid("6c55990a-3495-454a-9a98-2ca7fa851600"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "7773ae976c564ec2a0c3c574067f9681", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test17", "36D93169826AE4D6", 0, null, "test17" },
                    { new Guid("7f1c48ba-5cf8-4477-aeca-2fb06c09bfb6"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "51e5d7b9b2cd4508bbf776fffa561ba7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test12", "04254D7398FAFD10", 0, null, "test12" },
                    { new Guid("a4f013ed-531a-438a-ae78-b6be2f0200b5"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "d4952464e0c54278bc5014510badbfd6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test8", "D585B528016AE3C3", 0, null, "test8" },
                    { new Guid("bd7cd7d7-01df-4b72-ae9f-691802881a94"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "3db1bf3e00834571a5865a9ec4d9392d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test18", "1C7A9A7D91690F4C", 0, null, "test18" },
                    { new Guid("c5045e58-5ceb-48aa-bafc-7abadc0952dc"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "7b1aec06a308471e9a353f9eb7eead19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test5", "FC1E9762DA6CF20D", 0, null, "test5" },
                    { new Guid("c81a3ccc-884e-44a8-9937-692736d0c237"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "ed03f45b9cba483eb4cf64d9026788f4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test7", "ABC5E1536E58B483", 0, null, "test7" },
                    { new Guid("ca4aaba5-e9ef-43c2-8dbd-eaafb1c46b0a"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "dd2b6b7d8dc84f55bbaf52de27e3006c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test4", "97B3E418F3C1A592", 0, null, "test4" },
                    { new Guid("cd1cacd6-2d90-44ca-8400-66c8bc5e864c"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "3a90a5aa5ad8485bb63638ee4273a918", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test19", "076011017CED2D54", 0, null, "test19" },
                    { new Guid("cd4acb2d-4a8c-4981-9646-2423254ebe1f"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "c86d98fd587c4703b245995147d93cfe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test11", "D62EAF13CB075254", 0, null, "test11" },
                    { new Guid("d859c717-b6df-48f0-b67c-7e6eafc9c302"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "e7fd6e7050b64b43b3a4e298dd60968e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test14", "D746016D46FC7063", 0, null, "test14" },
                    { new Guid("d8bdefbe-db18-4bf9-a40f-ef0e54da5052"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "b322428aee5944e9ac8e8735384602b9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test16", "3890CB5E2648CF10", 0, null, "test16" },
                    { new Guid("e067aca3-ef0a-44d6-b5e9-9df3d909529a"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "1af5ab5f42ec418fa677ee30d1479d89", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test2", "0DB62979A80D15FD", 0, null, "test2" },
                    { new Guid("e674e4f7-2205-4898-9ab8-085c75742b5e"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "31aa208fd404424eb827283668867189", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test13", "6E6546EF70D3F22E", 0, null, "test13" },
                    { new Guid("fc05240e-ac56-4327-aec0-98d2bc430609"), "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg", "5d7fd32326dc46f0b41b594afefa3ea4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "{}", false, null, null, "test10", "BE64A2B9E212FF64", 0, null, "test10" }
                });

            migrationBuilder.InsertData(
                table: "UserRoleFunctions",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("147a1d2e-4485-4439-9ddf-c2cd0cdb9946"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("4be38eae-4bc2-418c-8477-0eb340897660") },
                    { new Guid("14a4177b-1bf4-414d-8235-56685dab8463"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("5bca363e-6e8d-4995-bd43-14231521f4da") },
                    { new Guid("189d37e4-f872-4227-a1a9-94d8ffa81d46"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("64eb7b10-9a8d-4e63-803f-9f9244a21c0b") },
                    { new Guid("1cf40120-90e2-456c-815e-8d3b2d92d598"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("15309642-a2f6-4995-9949-20b7f95cb9d3") },
                    { new Guid("39952631-8d13-464d-bf0b-1b04991083a7"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("6c55990a-3495-454a-9a98-2ca7fa851600") },
                    { new Guid("3fa5bdfd-c7a2-45e9-9207-683d6b33ba78"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("358acf33-b225-4004-a077-eaa82ba2cc81") },
                    { new Guid("4044d20c-39dc-4d47-8375-65438b5de1da"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("d8bdefbe-db18-4bf9-a40f-ef0e54da5052") },
                    { new Guid("556defc4-ca4d-460d-80f9-9e52b164d12a"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("ca4aaba5-e9ef-43c2-8dbd-eaafb1c46b0a") },
                    { new Guid("5f2ba24d-aa59-4749-8cf1-9a382b56a323"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("659777bd-35d6-4efc-866b-172609439f9d") },
                    { new Guid("75f279b2-3a1f-455f-8344-b9203d482815"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("cd1cacd6-2d90-44ca-8400-66c8bc5e864c") },
                    { new Guid("88b00fb0-59a7-4a0e-bc64-06a7cef42e3d"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("cd4acb2d-4a8c-4981-9646-2423254ebe1f") }
                });

            migrationBuilder.InsertData(
                table: "UserRoleFunctions",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9f26abc4-bbd9-4bf2-b36c-c040583e4b3c"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("fc05240e-ac56-4327-aec0-98d2bc430609") },
                    { new Guid("a2023eee-9ece-4ce3-bc47-689783c658c4"), new Guid("c84cf25e-1aa3-43e2-be90-ae6c42b5af7b"), new Guid("52cfff8a-3f7f-4d3b-a3a4-4ddacfb073a7") },
                    { new Guid("aa9e6dbc-d1ec-49d3-b5df-fc202344ef8a"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("a4f013ed-531a-438a-ae78-b6be2f0200b5") },
                    { new Guid("b259a236-6e16-4bbb-b526-fed2bf2efa11"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("e067aca3-ef0a-44d6-b5e9-9df3d909529a") },
                    { new Guid("d8407f47-1607-49f2-84a7-7f73ee0e78d3"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("e674e4f7-2205-4898-9ab8-085c75742b5e") },
                    { new Guid("db62d7bc-a983-4196-ab88-9967d624ad53"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("c5045e58-5ceb-48aa-bafc-7abadc0952dc") },
                    { new Guid("dfcd1a82-f023-4598-9dbf-204592cb6d53"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("d859c717-b6df-48f0-b67c-7e6eafc9c302") },
                    { new Guid("ea79e1ed-b814-47b9-a860-4d1f7da8f2a9"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("c81a3ccc-884e-44a8-9937-692736d0c237") },
                    { new Guid("f316afc9-6457-4721-951b-95ea380ee8ea"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("7f1c48ba-5cf8-4477-aeca-2fb06c09bfb6") },
                    { new Guid("ff00bad7-f8e1-4981-8ae3-b16489cbe7f5"), new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"), new Guid("bd7cd7d7-01df-4b72-ae9f-691802881a94") }
                });

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
