using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Simple.Shared
{
    public static class EnumException
    {

        public static string? GetDescription(this Enum value)
        {

            return value.GetType().GetMember(value.ToString()).FirstOrDefault()?.GetCustomAttribute<DescriptionAttribute>()?.Description ?? null;
        }
    }
}