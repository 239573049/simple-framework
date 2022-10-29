# 🎗️**迁移控制台程序**

**当前项目仅用来迁移数据库结构**

如果存在迁移记录可以启动程序更新数据库结构

## 生成 Simple 库的迁移文件 （需将 Init 修改为实际的改动名字）

```shell
dotnet ef migrations add Init --project ../efcore/EntityFrameworkCore.DbMigrations --context EfCoreMigrationDbContext 
```

## 执行库的最近一次迁移

```shell
dotnet ef database update --project ../efcore/EntityFrameworkCore.DbMigrations --context EfCoreMigrationDbContext
```

## 撤销上次迁移(-f 表示强制)
```shell
dotnet ef migrations remove -f --project ../efcore/EntityFrameworkCore.DbMigrations --context EfCoreMigrationDbContext
```

## 生成本次迁移的幂等SQL脚本（适合生产环境）
## 参考： https://docs.microsoft.com/zh-cn/ef/core/managing-schemas/migrations/applying?tabs=dotnet-core-cli#idempotent-sql-scripts

```shell
dotnet ef migrations script --idempotent --project ../efcore/EntityFrameworkCore.DbMigrations --context EfCoreMigrationDbContext


```

```shell
dotnet ef migrations script name --project ../efcore/EntityFrameworkCore.DbMigrations --context EfCoreMigrationDbContext
```