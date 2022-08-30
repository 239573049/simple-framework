using System;
using Microsoft.Extensions.DependencyInjection;

namespace Simple.Application.Contract
{
    public static class SimpleApplicationContractExtensions
    {
        public static IServiceCollection AddSimpleApplicationContract(this IServiceCollection services)
        {
            return services;
        }
    }
}