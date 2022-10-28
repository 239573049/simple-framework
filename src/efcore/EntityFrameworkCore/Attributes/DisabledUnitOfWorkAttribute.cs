using System;

namespace EntityFrameworkCore.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class DisabledUnitOfWorkAttribute : Attribute
{
    public readonly bool Disabled;

    public DisabledUnitOfWorkAttribute(bool disabled = true)
    {
        Disabled = disabled;
    }
}