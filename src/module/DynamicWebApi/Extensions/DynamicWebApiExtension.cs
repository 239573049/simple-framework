using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DynamicWebApi.Extensions
{
    public static class DynamicWebApiExtension
    {
        public static void ConfigureDynamicWebApi(this IMvcBuilder builder, Assembly assemblies)
        {
            builder.AddApplicationPart(assemblies);

            builder.ConfigureApplicationPartManager(builder =>
            {
                builder.FeatureProviders.Add(new ApplicationServiceControllerFeatureProvider());
            });

            builder.Services.Configure<MvcOptions>(options =>
            {
                options.Conventions.Add(new ApplicationServiceConvention());
            });

        }

        public static void ConfigureDynamicWebApi(this IMvcCoreBuilder builder, Assembly assemblies)
        {
            builder.AddApplicationPart(assemblies);

            builder.ConfigureApplicationPartManager(builder =>
            {
                builder.FeatureProviders.Add(new ApplicationServiceControllerFeatureProvider());
            });

            builder.Services.Configure<MvcOptions>(options =>
            {
                options.Conventions.Add(new ApplicationServiceConvention());
            });

        }
    }
}
