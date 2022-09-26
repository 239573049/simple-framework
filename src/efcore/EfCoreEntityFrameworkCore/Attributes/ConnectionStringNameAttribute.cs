using System;

namespace EfCoreEntityFrameworkCore.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class ConnectionStringNameAttribute : Attribute
{
    public readonly string ConnectionString;

    public ConnectionStringNameAttribute(string connectionString = "Default")
    {
        ConnectionString = connectionString;
    }
}