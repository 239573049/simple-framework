using Token.Module;
using Token.Module.Attributes;

namespace EfCoreEntityFrameworkCore.Mysql;

[DependOn(typeof(MysqlEfCoreEntityFrameworkCoreModule))]
public class MysqlEfCoreEntityFrameworkCoreModule : TokenModule
{
    
}