using Token;
using Token.Attributes;

namespace EntityFrameworkCore.Sqlite;

[DependOn(typeof(EntityFrameworkCoreModule))]
public class SqliteEntityFrameworkCoreModule : TokenModule
{

}