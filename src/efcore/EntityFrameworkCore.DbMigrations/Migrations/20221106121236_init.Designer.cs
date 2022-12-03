﻿// <auto-generated />
using System;
using EntityFrameworkCore.DbMigrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkCore.DbMigrations.Migrations
{
    [DbContext(typeof(EfCoreMigrationDbContext))]
    [Migration("20221106121236_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Simple.Admin.Domain.Systems.DictionarySetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeleteCreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Key");

                    b.ToTable("DictionarySettings", (string)null);
                });

            modelBuilder.Entity("Simple.Admin.Domain.Users.UserInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeleteCreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("UserInfos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("52cfff8a-3f7f-4d3b-a3a4-4ddacfb073a7"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "61ac8363905044d091f951de95335fb6",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "admin",
                            PassWord = "A279CD9A3FA16B2E",
                            Status = 0,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = new Guid("15309642-a2f6-4995-9949-20b7f95cb9d3"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "e6330a2b9ab84f16a2787d5fd87464d7",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test0",
                            PassWord = "B04A038088748D19",
                            Status = 0,
                            UserName = "test0"
                        },
                        new
                        {
                            Id = new Guid("5bca363e-6e8d-4995-bd43-14231521f4da"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "34b48ea750dd4800b1370dc5de1d1e3a",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test1",
                            PassWord = "8C10BEE192CBEED3",
                            Status = 0,
                            UserName = "test1"
                        },
                        new
                        {
                            Id = new Guid("e067aca3-ef0a-44d6-b5e9-9df3d909529a"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "1af5ab5f42ec418fa677ee30d1479d89",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test2",
                            PassWord = "0DB62979A80D15FD",
                            Status = 0,
                            UserName = "test2"
                        },
                        new
                        {
                            Id = new Guid("659777bd-35d6-4efc-866b-172609439f9d"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "07540b3457ba4f8488456577f750b281",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test3",
                            PassWord = "B0531A6647D5B767",
                            Status = 0,
                            UserName = "test3"
                        },
                        new
                        {
                            Id = new Guid("ca4aaba5-e9ef-43c2-8dbd-eaafb1c46b0a"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "dd2b6b7d8dc84f55bbaf52de27e3006c",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test4",
                            PassWord = "97B3E418F3C1A592",
                            Status = 0,
                            UserName = "test4"
                        },
                        new
                        {
                            Id = new Guid("c5045e58-5ceb-48aa-bafc-7abadc0952dc"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "7b1aec06a308471e9a353f9eb7eead19",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test5",
                            PassWord = "FC1E9762DA6CF20D",
                            Status = 0,
                            UserName = "test5"
                        },
                        new
                        {
                            Id = new Guid("64eb7b10-9a8d-4e63-803f-9f9244a21c0b"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "892078810e894ab1a9eabe90087b65cc",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test6",
                            PassWord = "469E814C186DC646",
                            Status = 0,
                            UserName = "test6"
                        },
                        new
                        {
                            Id = new Guid("c81a3ccc-884e-44a8-9937-692736d0c237"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "ed03f45b9cba483eb4cf64d9026788f4",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test7",
                            PassWord = "ABC5E1536E58B483",
                            Status = 0,
                            UserName = "test7"
                        },
                        new
                        {
                            Id = new Guid("a4f013ed-531a-438a-ae78-b6be2f0200b5"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "d4952464e0c54278bc5014510badbfd6",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test8",
                            PassWord = "D585B528016AE3C3",
                            Status = 0,
                            UserName = "test8"
                        },
                        new
                        {
                            Id = new Guid("358acf33-b225-4004-a077-eaa82ba2cc81"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "260d567098f6428cb8245051f1931ca8",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test9",
                            PassWord = "7B73D594C5AF69EB",
                            Status = 0,
                            UserName = "test9"
                        },
                        new
                        {
                            Id = new Guid("fc05240e-ac56-4327-aec0-98d2bc430609"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "5d7fd32326dc46f0b41b594afefa3ea4",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test10",
                            PassWord = "BE64A2B9E212FF64",
                            Status = 0,
                            UserName = "test10"
                        },
                        new
                        {
                            Id = new Guid("cd4acb2d-4a8c-4981-9646-2423254ebe1f"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "c86d98fd587c4703b245995147d93cfe",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test11",
                            PassWord = "D62EAF13CB075254",
                            Status = 0,
                            UserName = "test11"
                        },
                        new
                        {
                            Id = new Guid("7f1c48ba-5cf8-4477-aeca-2fb06c09bfb6"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "51e5d7b9b2cd4508bbf776fffa561ba7",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test12",
                            PassWord = "04254D7398FAFD10",
                            Status = 0,
                            UserName = "test12"
                        },
                        new
                        {
                            Id = new Guid("e674e4f7-2205-4898-9ab8-085c75742b5e"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "31aa208fd404424eb827283668867189",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test13",
                            PassWord = "6E6546EF70D3F22E",
                            Status = 0,
                            UserName = "test13"
                        },
                        new
                        {
                            Id = new Guid("d859c717-b6df-48f0-b67c-7e6eafc9c302"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "e7fd6e7050b64b43b3a4e298dd60968e",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test14",
                            PassWord = "D746016D46FC7063",
                            Status = 0,
                            UserName = "test14"
                        },
                        new
                        {
                            Id = new Guid("4be38eae-4bc2-418c-8477-0eb340897660"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "44240aa0ac394d2c997c4e7ef7c099fa",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test15",
                            PassWord = "A8283C23A894B3DB",
                            Status = 0,
                            UserName = "test15"
                        },
                        new
                        {
                            Id = new Guid("d8bdefbe-db18-4bf9-a40f-ef0e54da5052"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "b322428aee5944e9ac8e8735384602b9",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test16",
                            PassWord = "3890CB5E2648CF10",
                            Status = 0,
                            UserName = "test16"
                        },
                        new
                        {
                            Id = new Guid("6c55990a-3495-454a-9a98-2ca7fa851600"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "7773ae976c564ec2a0c3c574067f9681",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test17",
                            PassWord = "36D93169826AE4D6",
                            Status = 0,
                            UserName = "test17"
                        },
                        new
                        {
                            Id = new Guid("bd7cd7d7-01df-4b72-ae9f-691802881a94"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "3db1bf3e00834571a5865a9ec4d9392d",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test18",
                            PassWord = "1C7A9A7D91690F4C",
                            Status = 0,
                            UserName = "test18"
                        },
                        new
                        {
                            Id = new Guid("cd1cacd6-2d90-44ca-8400-66c8bc5e864c"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "3a90a5aa5ad8485bb63638ee4273a918",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            IsDeleted = false,
                            Name = "test19",
                            PassWord = "076011017CED2D54",
                            Status = 0,
                            UserName = "test19"
                        });
                });

            modelBuilder.Entity("Simple.Auth.Domain.Menus.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Component")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("前端对应组件");

                    b.Property<string>("ConcurrencyStamp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeleteCreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("图标");

                    b.Property<int>("Index")
                        .HasColumnType("int")
                        .HasComment("顺序");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("上级id 为null表示当前为顶层");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("前端跳转路由");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("菜单显示标题");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Menus", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d1e27f9f-23bf-4481-b9a5-f6d8ddee01d9"),
                            Component = "@/pages/admin/home",
                            ConcurrencyStamp = "1767872be6b8422b9ce42c81eedaa03a",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            Icon = "IconHome",
                            Index = 0,
                            IsDeleted = false,
                            Path = "/",
                            Title = "首页"
                        },
                        new
                        {
                            Id = new Guid("0cd91965-9056-4e90-bd05-df27a125026f"),
                            Component = "@/pages/admin/menu",
                            ConcurrencyStamp = "64d60ff804be40efa04679ce97e1f2fd",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            Icon = "IconMenu",
                            Index = 1,
                            IsDeleted = false,
                            Path = "/menu",
                            Title = "菜单管理"
                        },
                        new
                        {
                            Id = new Guid("61fd1f15-b1b9-4360-96e2-b15fdd6a9c0c"),
                            Component = "@/pages/admin/dictionary-settings",
                            ConcurrencyStamp = "976a1200eeb34d7796e56d9ecf5b7f01",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            Icon = "IconArticle",
                            Index = 2,
                            IsDeleted = false,
                            Path = "/dictionary-settings",
                            Title = "字典设置"
                        },
                        new
                        {
                            Id = new Guid("750d1d79-7ac6-4115-aae6-9c6cebcb59c7"),
                            Component = "@/pages/admin/user",
                            ConcurrencyStamp = "589ac2acf92949c29178f65eb378f297",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            Icon = "IconUser",
                            Index = 3,
                            IsDeleted = false,
                            Path = "/user",
                            Title = "用户管理"
                        });
                });

            modelBuilder.Entity("Simple.Auth.Domain.Roles.MenuRoleFunction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MenuId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("菜单Id");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("角色Id");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("MenuRoleFunctions", (string)null);

                    b.HasComment("菜单角色配置");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b4afad7e-0732-4486-90c8-24ebed7ed7cf"),
                            MenuId = new Guid("d1e27f9f-23bf-4481-b9a5-f6d8ddee01d9"),
                            RoleId = new Guid("c84cf25e-1aa3-43e2-be90-ae6c42b5af7b")
                        },
                        new
                        {
                            Id = new Guid("eb0c8349-f5ea-49e7-a8d0-74e83d09d5ae"),
                            MenuId = new Guid("0cd91965-9056-4e90-bd05-df27a125026f"),
                            RoleId = new Guid("c84cf25e-1aa3-43e2-be90-ae6c42b5af7b")
                        },
                        new
                        {
                            Id = new Guid("9338ce22-9508-4a3f-b850-cdfb9ef71e7c"),
                            MenuId = new Guid("61fd1f15-b1b9-4360-96e2-b15fdd6a9c0c"),
                            RoleId = new Guid("c84cf25e-1aa3-43e2-be90-ae6c42b5af7b")
                        },
                        new
                        {
                            Id = new Guid("01b9b35a-245b-47c6-9f4b-2a32a6ad1e8b"),
                            MenuId = new Guid("750d1d79-7ac6-4115-aae6-9c6cebcb59c7"),
                            RoleId = new Guid("c84cf25e-1aa3-43e2-be90-ae6c42b5af7b")
                        });
                });

            modelBuilder.Entity("Simple.Auth.Domain.Roles.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("编号");

                    b.Property<string>("ConcurrencyStamp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeleteCreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Index")
                        .HasColumnType("int")
                        .HasComment("顺序");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("bit")
                        .HasComment("是否私有 私有无法删除");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("角色名称");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Roles", (string)null);

                    b.HasComment("角色");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c84cf25e-1aa3-43e2-be90-ae6c42b5af7b"),
                            Code = "admin",
                            ConcurrencyStamp = "52c7c25d0dee4802a1d2f4614bd4b4c3",
                            CreationTime = new DateTime(2022, 11, 6, 20, 12, 36, 450, DateTimeKind.Local).AddTicks(1543),
                            ExtraProperties = "{}",
                            Index = 1,
                            IsDeleted = false,
                            IsPrivate = true,
                            Name = "admin"
                        },
                        new
                        {
                            Id = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            Code = "user",
                            ConcurrencyStamp = "43232c0d21054de09d3a885a665d883e",
                            CreationTime = new DateTime(2022, 11, 6, 20, 12, 36, 450, DateTimeKind.Local).AddTicks(1563),
                            ExtraProperties = "{}",
                            Index = 2,
                            IsDeleted = false,
                            IsPrivate = true,
                            Name = "user"
                        });
                });

            modelBuilder.Entity("Simple.Auth.Domain.Roles.UserRoleFunction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("角色Id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("用户id");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("UserRoleFunctions", (string)null);

                    b.HasComment("用户角色配置");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1cf40120-90e2-456c-815e-8d3b2d92d598"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("15309642-a2f6-4995-9949-20b7f95cb9d3")
                        },
                        new
                        {
                            Id = new Guid("14a4177b-1bf4-414d-8235-56685dab8463"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("5bca363e-6e8d-4995-bd43-14231521f4da")
                        },
                        new
                        {
                            Id = new Guid("b259a236-6e16-4bbb-b526-fed2bf2efa11"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("e067aca3-ef0a-44d6-b5e9-9df3d909529a")
                        },
                        new
                        {
                            Id = new Guid("5f2ba24d-aa59-4749-8cf1-9a382b56a323"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("659777bd-35d6-4efc-866b-172609439f9d")
                        },
                        new
                        {
                            Id = new Guid("556defc4-ca4d-460d-80f9-9e52b164d12a"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("ca4aaba5-e9ef-43c2-8dbd-eaafb1c46b0a")
                        },
                        new
                        {
                            Id = new Guid("db62d7bc-a983-4196-ab88-9967d624ad53"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("c5045e58-5ceb-48aa-bafc-7abadc0952dc")
                        },
                        new
                        {
                            Id = new Guid("189d37e4-f872-4227-a1a9-94d8ffa81d46"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("64eb7b10-9a8d-4e63-803f-9f9244a21c0b")
                        },
                        new
                        {
                            Id = new Guid("ea79e1ed-b814-47b9-a860-4d1f7da8f2a9"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("c81a3ccc-884e-44a8-9937-692736d0c237")
                        },
                        new
                        {
                            Id = new Guid("aa9e6dbc-d1ec-49d3-b5df-fc202344ef8a"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("a4f013ed-531a-438a-ae78-b6be2f0200b5")
                        },
                        new
                        {
                            Id = new Guid("3fa5bdfd-c7a2-45e9-9207-683d6b33ba78"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("358acf33-b225-4004-a077-eaa82ba2cc81")
                        },
                        new
                        {
                            Id = new Guid("9f26abc4-bbd9-4bf2-b36c-c040583e4b3c"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("fc05240e-ac56-4327-aec0-98d2bc430609")
                        },
                        new
                        {
                            Id = new Guid("88b00fb0-59a7-4a0e-bc64-06a7cef42e3d"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("cd4acb2d-4a8c-4981-9646-2423254ebe1f")
                        },
                        new
                        {
                            Id = new Guid("f316afc9-6457-4721-951b-95ea380ee8ea"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("7f1c48ba-5cf8-4477-aeca-2fb06c09bfb6")
                        },
                        new
                        {
                            Id = new Guid("d8407f47-1607-49f2-84a7-7f73ee0e78d3"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("e674e4f7-2205-4898-9ab8-085c75742b5e")
                        },
                        new
                        {
                            Id = new Guid("dfcd1a82-f023-4598-9dbf-204592cb6d53"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("d859c717-b6df-48f0-b67c-7e6eafc9c302")
                        },
                        new
                        {
                            Id = new Guid("147a1d2e-4485-4439-9ddf-c2cd0cdb9946"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("4be38eae-4bc2-418c-8477-0eb340897660")
                        },
                        new
                        {
                            Id = new Guid("4044d20c-39dc-4d47-8375-65438b5de1da"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("d8bdefbe-db18-4bf9-a40f-ef0e54da5052")
                        },
                        new
                        {
                            Id = new Guid("39952631-8d13-464d-bf0b-1b04991083a7"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("6c55990a-3495-454a-9a98-2ca7fa851600")
                        },
                        new
                        {
                            Id = new Guid("ff00bad7-f8e1-4981-8ae3-b16489cbe7f5"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("bd7cd7d7-01df-4b72-ae9f-691802881a94")
                        },
                        new
                        {
                            Id = new Guid("75f279b2-3a1f-455f-8344-b9203d482815"),
                            RoleId = new Guid("225e1bad-ca70-4c5b-8952-efdbe0e02c27"),
                            UserId = new Guid("cd1cacd6-2d90-44ca-8400-66c8bc5e864c")
                        },
                        new
                        {
                            Id = new Guid("a2023eee-9ece-4ce3-bc47-689783c658c4"),
                            RoleId = new Guid("c84cf25e-1aa3-43e2-be90-ae6c42b5af7b"),
                            UserId = new Guid("52cfff8a-3f7f-4d3b-a3a4-4ddacfb073a7")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}