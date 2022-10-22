# 🎈Sqlite模块
当前模块对应Sqlite数据库

## 🛎️使用方法
1. 替换模块引用的其他的数据库模块  替换成 [DependOn(typeof(SqliteEntityFrameworkCoreModule))]
2. 注入扩展方法
```csharp
// MyDbContext 对应您的模块的DbContext

services.AddSqliteEfCoreEntityFrameworkCore<MyDbContext>();
```