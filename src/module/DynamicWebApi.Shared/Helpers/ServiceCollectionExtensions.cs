using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DynamicWebApi.Shared.Helpers
{
    public static class ServiceCollectionExtensions
    {
        public static bool IsAdded<T>(this IServiceCollection services)
        {
            return services.IsAdded(typeof(T));
        }

        public static bool IsAdded(this IServiceCollection services, Type type)
        {
            return services.Any(d => d.ServiceType == type);
        }

        public static T GetSingletonInstanceOrNull<T>(this IServiceCollection services)
        {
            return (T)services
                .FirstOrDefault(d => d.ServiceType == typeof(T))
                ?.ImplementationInstance;
        }

        public static T GetSingletonInstance<T>(this IServiceCollection services)
        {
            var service = services.GetSingletonInstanceOrNull<T>();
            if (service == null)
            {
                throw new InvalidOperationException("Could not find singleton service: " + typeof(T).AssemblyQualifiedName);
            }

            return service;
        }

        public static IServiceProvider BuildServiceProviderFromFactory<TContainerBuilder>(this IServiceCollection services, Action<TContainerBuilder> builderAction = null)
        {

            var serviceProviderFactory = services.GetSingletonInstanceOrNull<IServiceProviderFactory<TContainerBuilder>>();
            if (serviceProviderFactory == null)
            {
                throw new Exception($"Could not find {typeof(IServiceProviderFactory<TContainerBuilder>).FullName} in {services}.");
            }

            var builder = serviceProviderFactory.CreateBuilder(services);
            builderAction?.Invoke(builder);
            return serviceProviderFactory.CreateServiceProvider(builder);
        }
    }
}