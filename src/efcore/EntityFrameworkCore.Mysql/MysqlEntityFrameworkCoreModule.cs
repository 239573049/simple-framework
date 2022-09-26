using Token.Module;
using Token.Module.Attributes;

namespace EntityFrameworkCore.Mysql;

[DependOn(typeof(EntityFrameworkCoreModule))]
public class MysqlEntityFrameworkCoreModule : TokenModule
{
    
}