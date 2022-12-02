using Token;
using Token.Attributes;

namespace EntityFrameworkCore.Mysql;

[DependOn(typeof(EntityFrameworkCoreModule))]
public class MysqlEntityFrameworkCoreModule : TokenModule
{

}