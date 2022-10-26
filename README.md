# SimpleFramework

---

文档语言: [[English](README.en.md)] | [[简体中文](README.md)]

## 🎈 介绍

简化框架，封装了 EFcore 仓储，工作单元
框架结构分明

[![NuGet](https://img.shields.io/nuget/dt/Simple.Framework.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/Simple.Framework/)
[![NuGet](https://img.shields.io/nuget/v/Simple.Framework.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/Simple.Framework/)

![Alt](https://repobeats.axiom.co/api/embed/17958d5a05cdd2ceebafc987ad9be05de01c4b31.svg "Repobeats analytics image")

### 模板安装

安装 simple 模板

```shell
dotnet new --install Simple.Framework
```

创建 simple 模板

```shell
dotnet new simple --name MyProjectName
```

生成新模板包 (必须在 cmd 中执行)

```shell
nuget pack ./Simple.Framework.nuspec
```

## 🎞️ 项目结构

/src // 项目文件夹

/src/Simple.DbMigrations // 迁移文件管理项目

/src/Simple.EntityFrameworkCore // 当前领域的仓储实现和 Dbcontext

/src/Simple.Application.Contract // 契约

/src/Simple.Application // 业务层

/src/efcore // 框架的一些 EfCore 封装

/src/efcore/EfCoreEntityFrameworkCore // EfCore 基础封装

/src/efcore/EfCoreEntityFrameworkCore.DbMigrations // 项目所有 EfCore 迁移文件存放

/src/efcore/EfCoreEntityFrameworkCore.Mysql // 数据库 Mysql 模块实现

/src/efcore/EfCoreEntityFrameworkCore.SqlServer // SqlServer 数据库模块实现

/src/efcore/EfCoreEntityFrameworkCore.Sqlite // Sqlite 数据库模块实现

/src/auth // 授权服务 （单独部署）

## 🍬 基本功能

1. 实现基本软删功能
2. 实现创建人删除人更新人赋值
3. 实现租户功能（未测试）
4. 实现基本的授权服务
5. 实现基本用户功能

## 🏴‍☠️ 构建项目

构建打包 Simple 项目的 Docker 镜像

```shell
docker build -f ./src/Simple.HttpApi.Host/Dockerfile -t simple .
```

构建打包 Simple-Auth 项目的 Docker 镜像

```shell
docker build -f ./src/auth/Simple.Auth.HttpApi.Host/Dockerfile -t auth .
```

## 🛞 使用说明

**_首先需要修改 Simple.HttpApi.Host，Simple.DbMigrations，Simple.Auth.HttpApi.Host 的项目下的 appsettings.json 的 mysql 数据库连接字符串_**

**_在 Simple.DbMigrations 生成迁移文件然后更新迁移文件_**

## 技术交流
QQ群：737776595

