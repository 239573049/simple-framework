# SimpleFramework

---

The document language: [[English](README.en.md)] | [[简体中文](README.md)]

## 🎈 is introduced

Simplified framework encapsulates EFcore warehousing, work units

Clear frame structure

[![NuGet](https://img.shields.io/nuget/dt/Simple.Framework.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/Simple.Framework/)
[![NuGet](https://img.shields.io/nuget/v/Simple.Framework.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/Simple.Framework/)

![Alt](https://repobeats.axiom.co/api/embed/17958d5a05cdd2ceebafc987ad9be05de01c4b31.svg "Repobeats analytics image")

### template installation

Installing the simple Template

```shell
dotnet new --install Simple.Framework
```

Creating a simple Template

```shell
dotnet new simple --name MyProjectName
```

Generate a new template package (must be done in cmd)

```shell
nuget pack ./Simple.Framework.nuspec
```

## 🎞 ️ project structure

/src // Project folder

/src/Simple.DbMigrations // Migrate file management projects

./src/Simple EntityFrameworkCore / / warehousing implementation in the field of current and Dbcontext

/src/Simple. Application. Contract / / Contract

/src/ simp. Application // Business layer

/src/efcore // Some EfCore packaging for the framework

/src/efcore EfCoreEntityFrameworkCore / / efcore based encapsulation

./src/efcore/EfCoreEntityFrameworkCore DbMigrations / / project all efcore migration file storage

./src/efcore EfCoreEntityFrameworkCore/Mysql / / Mysql database module implementation

/src/efcore/EfCoreEntityFrameworkCore. Essentially a / / used database module implementation

. /src/efcore/EfCoreEntityFrameworkCore Sqlite / / Sqlite database module implementation

/src/auth // Licensing service (standalone deployment)

## 🍬 Basic functions

1. Implement the basic soft delete function

2. Implement the creator to delete the person and update the person assignment

3. Implement tenant functions (not tested)

4. Implement basic authorization services

5. Implement basic user functions

## 🏴‍☠️ Build the project

Build the Docker image that packages the Simple project

```shell
docker build -f ./src/Simple.HttpApi.Host/Dockerfile -t simple .
```

Build the Docker image that packages the Simple-Auth project

```shell
docker build -f ./src/auth/Simple.Auth.HttpApi.Host/Dockerfile -t auth .
```

## 🛞instructions

**_First you need to modify the appsettings.json mysql database connection string under the simply.httpapi.host, simply.dbmigrations, simply.auth.httpapi.host project_**

**_Generate the migration file at Simple.DbMigrations and then update the migration file_**
