using Token.Module;
using Token.Module.Attributes;

namespace EfCoreEntityFrameworkCore.SqlServer;

[DependOn(typeof(EfCoreEntityFrameworkCoreModule))]
public class SqlServerEfCoreEntityFrameworkCoreModule: TokenModule
{
    
}