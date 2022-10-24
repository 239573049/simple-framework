using Token.Module;
using Token.Module.Attributes;

namespace EntityFrameworkCore.SqlServer;

[DependOn(typeof(EntityFrameworkCoreModule))]
public class SqlServerEntityFrameworkCoreModule : TokenModule
{

}