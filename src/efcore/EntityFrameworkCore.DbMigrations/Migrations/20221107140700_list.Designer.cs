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
    [Migration("20221107140700_list")]
    partial class list
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
                            Id = new Guid("9dc268b2-62ba-48ea-a2ea-ed2b80b13fc7"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "6b6ab9227f3f48f8bfc0409d2eb3efcc",
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
                            Id = new Guid("ccb6b9b9-479c-40aa-8dac-b9523b737eba"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "c1085da2d27f442181549f38e6904392",
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
                            Id = new Guid("06050b50-fe04-4dd3-a95d-ee441e75d69a"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "3bee9f2421ec48899b257b45d513739f",
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
                            Id = new Guid("82091133-1447-4101-9117-a35f32ee4034"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "add1151220324dd4833198d796135238",
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
                            Id = new Guid("89a10eda-4923-46c2-b9c1-2c2af00876e6"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "e3b2634714c04d21accded17fe187836",
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
                            Id = new Guid("91e84bce-dc5d-498e-b415-7ce7a02cd418"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "d64212ced1b24cdeb12cfe9b6d05f995",
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
                            Id = new Guid("36b23b5a-b2d3-4ce6-9687-10f78c05aa8c"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "4979da6ea25e40eba09af7955ad97afd",
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
                            Id = new Guid("f1b7327d-ac61-4b18-bb29-92222ab16ef6"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "1a9e3d4372b44201ad156d67844cc291",
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
                            Id = new Guid("5c107f4a-66b2-40c3-aa82-e1f7ec1f4273"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "87c7be1ea37f4dbb9f3e22b2d55271ee",
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
                            Id = new Guid("62fc2ba7-3f42-4095-8603-d688e8a3dd68"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "e175302c1eea433b8ca20c185c08188a",
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
                            Id = new Guid("b805b244-614d-45aa-b023-c24ba1a7a866"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "7218a8662c2d4506aa97951308af4aa3",
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
                            Id = new Guid("5afb6043-c13d-4dab-b3f4-ea6be13878d7"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "6dc304ede71442059d97c6aabd219c50",
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
                            Id = new Guid("8be4b24f-7c88-43a8-803e-0cfca5988dd6"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "219b88d24af94788bbecdd892c760726",
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
                            Id = new Guid("11b2514b-7b2c-45de-8ea7-a28399fac87e"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "dbc07a4aae4c441f90fb20c7b4f45c29",
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
                            Id = new Guid("a4ede67b-e6c8-434a-9d95-8c19c74137c0"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "6f6c3282e4c849149998c41d8e9a597e",
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
                            Id = new Guid("f8418fbb-5ee6-4643-b3b2-decf284b7d23"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "3ea96f5f7623451e8c0fabd4b12112b6",
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
                            Id = new Guid("6553297b-10ba-41eb-85b1-7c830f262cf4"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "9dac173f969a447e98368325f6f9d6d2",
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
                            Id = new Guid("6af0ff9c-9b0d-487a-9045-d3811d5ea82b"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "a5820f9f3c20407f9d807e7d0e412e97",
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
                            Id = new Guid("d8a7c3ee-cb61-4db0-9238-174557fc470d"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "56eb5be229be4796a964cd9541f5388f",
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
                            Id = new Guid("b30b1af9-a4eb-48c9-94c9-e944038c3ab6"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "668f4faa37dc4547bb644e4f43842599",
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
                            Id = new Guid("4078d03f-c889-439a-bca2-3a8b11305425"),
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/OIP-C.jpg",
                            ConcurrencyStamp = "e7d7a02dea7c44298b777aa4873dcf16",
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
                            Id = new Guid("42a6bcf3-ac48-44ce-b9f8-b0cdbb83d3dd"),
                            Component = "@/pages/admin/home",
                            ConcurrencyStamp = "09445577e36e4ac5974c21820b374c18",
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
                            Id = new Guid("1a355cca-7737-417c-a756-f68b9caed755"),
                            Component = "@/pages/admin/menu",
                            ConcurrencyStamp = "d3ebad92be654233bb8d35948770895b",
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
                            Id = new Guid("5f3c49a7-6f4c-43b1-ba37-e0bdd2877024"),
                            Component = "@/pages/admin/dictionary-settings",
                            ConcurrencyStamp = "7fc1819c7e154888baf100d03c3baa05",
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
                            Id = new Guid("e38dd69f-983a-4bd9-aee6-a60310d576a9"),
                            Component = "@/pages/admin/user",
                            ConcurrencyStamp = "13e3682315624c46b7a372d9422c3de9",
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
                            Id = new Guid("e095a9fd-dac0-4224-ac3d-8f76745d2cda"),
                            MenuId = new Guid("42a6bcf3-ac48-44ce-b9f8-b0cdbb83d3dd"),
                            RoleId = new Guid("40d55655-afda-4629-a71f-97a0de98ef77")
                        },
                        new
                        {
                            Id = new Guid("3e3a5016-1ba3-4226-8276-f644785e2902"),
                            MenuId = new Guid("1a355cca-7737-417c-a756-f68b9caed755"),
                            RoleId = new Guid("40d55655-afda-4629-a71f-97a0de98ef77")
                        },
                        new
                        {
                            Id = new Guid("b7f65cc5-28fb-4066-b883-d9f9f7079719"),
                            MenuId = new Guid("5f3c49a7-6f4c-43b1-ba37-e0bdd2877024"),
                            RoleId = new Guid("40d55655-afda-4629-a71f-97a0de98ef77")
                        },
                        new
                        {
                            Id = new Guid("92b99180-b6bb-4e13-ac6a-5fd0b71bac86"),
                            MenuId = new Guid("e38dd69f-983a-4bd9-aee6-a60310d576a9"),
                            RoleId = new Guid("40d55655-afda-4629-a71f-97a0de98ef77")
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
                            Id = new Guid("40d55655-afda-4629-a71f-97a0de98ef77"),
                            Code = "admin",
                            ConcurrencyStamp = "d1d00de9b19344bfac18246bc64de119",
                            CreationTime = new DateTime(2022, 11, 7, 22, 6, 59, 680, DateTimeKind.Local).AddTicks(7369),
                            ExtraProperties = "{}",
                            Index = 1,
                            IsDeleted = false,
                            IsPrivate = true,
                            Name = "admin"
                        },
                        new
                        {
                            Id = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            Code = "user",
                            ConcurrencyStamp = "854045a271454a1d96b8ce957dae367a",
                            CreationTime = new DateTime(2022, 11, 7, 22, 6, 59, 680, DateTimeKind.Local).AddTicks(7386),
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
                            Id = new Guid("c0c073e5-0a93-44ee-bde6-a2b2aab28c4b"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("ccb6b9b9-479c-40aa-8dac-b9523b737eba")
                        },
                        new
                        {
                            Id = new Guid("e68a4205-b7c5-41f9-bbca-ab0f44d3af24"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("06050b50-fe04-4dd3-a95d-ee441e75d69a")
                        },
                        new
                        {
                            Id = new Guid("c0ddc9c3-e17d-4adc-b79c-64a74c14a01d"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("82091133-1447-4101-9117-a35f32ee4034")
                        },
                        new
                        {
                            Id = new Guid("caf9ae17-6d17-47f8-8959-7bcb106e1422"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("89a10eda-4923-46c2-b9c1-2c2af00876e6")
                        },
                        new
                        {
                            Id = new Guid("ad2f9b15-dcfb-4d5d-beff-7941d4b0c2b9"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("91e84bce-dc5d-498e-b415-7ce7a02cd418")
                        },
                        new
                        {
                            Id = new Guid("9b14c568-1376-44e3-bbb9-c8907a1a35c6"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("36b23b5a-b2d3-4ce6-9687-10f78c05aa8c")
                        },
                        new
                        {
                            Id = new Guid("a4a87615-2f74-4c89-9ecc-f110272232e0"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("f1b7327d-ac61-4b18-bb29-92222ab16ef6")
                        },
                        new
                        {
                            Id = new Guid("e95cd7df-33cf-48b8-b186-0f4af79a8eeb"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("5c107f4a-66b2-40c3-aa82-e1f7ec1f4273")
                        },
                        new
                        {
                            Id = new Guid("8cd5818d-de1b-41dd-9d04-ed492ce5f4fb"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("62fc2ba7-3f42-4095-8603-d688e8a3dd68")
                        },
                        new
                        {
                            Id = new Guid("72f449d1-e051-4830-8c2c-14229e4c1ece"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("b805b244-614d-45aa-b023-c24ba1a7a866")
                        },
                        new
                        {
                            Id = new Guid("40d728d8-25db-46bc-8120-63e5384d8100"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("5afb6043-c13d-4dab-b3f4-ea6be13878d7")
                        },
                        new
                        {
                            Id = new Guid("639c3c3e-0d0f-46b0-8779-7bfdd3b2e867"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("8be4b24f-7c88-43a8-803e-0cfca5988dd6")
                        },
                        new
                        {
                            Id = new Guid("50fb51c1-84d3-4e68-bed2-089196454cb3"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("11b2514b-7b2c-45de-8ea7-a28399fac87e")
                        },
                        new
                        {
                            Id = new Guid("5834eb7a-2989-4e55-911f-7688de1e762d"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("a4ede67b-e6c8-434a-9d95-8c19c74137c0")
                        },
                        new
                        {
                            Id = new Guid("bab1b2ac-27a3-4fae-8669-5c38b035028c"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("f8418fbb-5ee6-4643-b3b2-decf284b7d23")
                        },
                        new
                        {
                            Id = new Guid("4d34351f-5d5c-4ce6-b287-227d7acc2a65"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("6553297b-10ba-41eb-85b1-7c830f262cf4")
                        },
                        new
                        {
                            Id = new Guid("623f10b6-1fe0-4f1e-9188-31a9b88245d8"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("6af0ff9c-9b0d-487a-9045-d3811d5ea82b")
                        },
                        new
                        {
                            Id = new Guid("88f8810a-5e28-447e-9bc6-b3cff51479a6"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("d8a7c3ee-cb61-4db0-9238-174557fc470d")
                        },
                        new
                        {
                            Id = new Guid("c68bf50d-b4a5-4163-9e44-5ca8525a5bee"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("b30b1af9-a4eb-48c9-94c9-e944038c3ab6")
                        },
                        new
                        {
                            Id = new Guid("19fac0ad-a22b-4e94-81ea-9ef0a96ae24a"),
                            RoleId = new Guid("915fdc66-3736-46d9-8ee5-b3d68d078f43"),
                            UserId = new Guid("4078d03f-c889-439a-bca2-3a8b11305425")
                        },
                        new
                        {
                            Id = new Guid("2172dde7-bcd1-4f55-818e-c6b494e3b7a8"),
                            RoleId = new Guid("40d55655-afda-4629-a71f-97a0de98ef77"),
                            UserId = new Guid("9dc268b2-62ba-48ea-a2ea-ed2b80b13fc7")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}