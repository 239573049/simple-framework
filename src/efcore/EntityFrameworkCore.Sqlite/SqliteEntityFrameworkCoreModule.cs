using Token.Module;
using Token.Module.Attributes;

namespace EntityFrameworkCore.Sqlite;

[DependOn(typeof(EntityFrameworkCoreModule))]
public class SqliteEntityFrameworkCoreModule : TokenModule
{
    
}