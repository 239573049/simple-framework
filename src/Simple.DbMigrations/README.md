# 生成 Iot 库的迁移文件 （需将 Init 修改为实际的改动名字）

```shell
dotnet ef migrations add init --project ../efcore/EfCoreEntityFrameworkCore.DbMigrations
```

# 执行  库的最近一次迁移

```shell
dotnet ef database update --project ../efcore/EfCoreEntityFrameworkCore.DbMigrations
```

# 撤销上次迁移(-f 表示强制)
```shell
dotnet ef migrations remove -f --project ../efcore/EfCoreEntityFrameworkCore.DbMigrations
```

# 生成本次迁移的幂等SQL脚本（适合生产环境）
# 参考： https://docs.microsoft.com/zh-cn/ef/core/managing-schemas/migrations/applying?tabs=dotnet-core-cli#idempotent-sql-scripts
#dotnet ef migrations script --idempotent --project ../efcore/EfCoreEntityFrameworkCore.DbMigrations
dotnet ef migrations script ScriptName --project ../efcore/EfCoreEntityFrameworkCore.DbMigrations