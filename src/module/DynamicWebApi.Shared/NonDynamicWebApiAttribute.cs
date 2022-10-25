using System;

namespace DynamicWebApi.Shared
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Method)]
    public class NonDynamicWebApiAttribute : Attribute
    {

    }
}