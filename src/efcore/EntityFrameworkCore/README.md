# 🎈EfCore基础模块
扩展其他数据库支持模块时引用当前模块
并且重新实现扩展参考MySql 或者 SqlServer 的模块实现 

## 🛎️使用方法
1. 替换模块引用的其他的数据库模块  替换成 [DependOn(typeof(EfCoreEntityFrameworkCoreModule))]
2. 注入扩展方法 具体实现参考 MySql 或者 SqlServer 的模块扩展方法实现


## 使用事件中间件

```csharp
// 注入自动事务中间件
services.AddUnitOfWorkMiddleware();

....

// 注册自动工作单元中间件
app.UseUnitOfWorkMiddleware();

```

禁用工作单元使用`[DisabledUnitOfWork]`添加到需要禁用事件的控制器中
