using System;
using System.Reflection;
using DynamicWebApi.Shared;
using DynamicWebApi.Shared.Helpers;

namespace DynamicWebApi
{
    public interface ISelectController
    {
        bool IsController(Type type);
    }

    public class DefaultSelectController : ISelectController
    {
        public bool IsController(Type type)
        {
            var typeInfo = type.GetTypeInfo();

            if (!typeof(IApplicationService).IsAssignableFrom(type) ||
                !typeInfo.IsPublic || typeInfo.IsAbstract || typeInfo.IsGenericType)
            {
                return false;
            }


            var attr = ReflectionHelper.GetSingleAttributeOrDefaultByFullSearch<DynamicWebApiAttribute>(typeInfo);

            if (attr == null)
            {
                return false;
            }

            if (ReflectionHelper.GetSingleAttributeOrDefaultByFullSearch<NonDynamicWebApiAttribute>(typeInfo) != null)
            {
                return false;
            }

            return true;
        }
    }
}