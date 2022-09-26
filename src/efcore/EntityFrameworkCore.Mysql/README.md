# 🎈Mysql模块
当前模块对应Mysql数据库

## 🛎️使用方法
1. 替换模块引用的其他的数据库模块  替换成 [DependOn(typeof(MysqlEfCoreEntityFrameworkCoreModule))]
2. 注入扩展方法
```csharp
// MyDbContext 对应您的模块的DbContext
// Version 对应Mysql版本

services.AddMysqlEfCoreEntityFrameworkCore<MyDbContext>(new Version(8,0,10);
```