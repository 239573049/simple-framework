using Simple.Common.Jwt;
using Token.Module;
using Token.Module.Attributes;

namespace EntityFrameworkCore;

[DependOn(typeof(SimpleCommonJwtModule))]
public class EntityFrameworkCoreModule : TokenModule
{
}