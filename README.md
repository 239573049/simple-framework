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
`用来发布新模块版本`

```shell
nuget pack ./Simple.Framework.nuspec
```

## 项目部署

项目将通过 docker compose 一键部署

实现记得部署好 mssql 然后启动 Simple.DbMigrations 项目执行迁移

注意：先修改项目配置文件的连接字符串

**_构建项目_**

```shell
docker-compose build
```

**_启动项目_**

```shell
docker-compose up -d
```

**_销毁项目_**

```shell
docker-compose down
```

## 🍬 基本功能

- [x] 实现基本软删功能

- [x] 实现创建人删除人更新人赋值

- [x] 实现基本的授权服务

- [x] 实现基本用户功能

- [ ] 实现分布式事件总线

- [ ] 实现审计日志

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

QQ 群：737776595
