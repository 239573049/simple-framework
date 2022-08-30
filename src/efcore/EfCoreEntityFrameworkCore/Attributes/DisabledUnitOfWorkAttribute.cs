using System;

namespace EfCoreEntityFrameworkCore.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class DisabledUnitOfWorkAttribute : Attribute
{
    public readonly bool Disabled;

    public DisabledUnitOfWorkAttribute(bool disabled = true)
    {
        Disabled = disabled;
    }
}