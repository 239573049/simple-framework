using EfCoreEntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Simple.Domain.Users;

namespace Simple.EntityFrameworkCore;

public static class SimpleEntityFrameworkCoreExtensions
{
    public static IServiceCollection AddSimpleEntityFrameworkCore(this IServiceCollection services)
    {
        services.AddEfCoreEntityFrameworkCore<SimpleDbContext>();
        services.AddTransient(typeof(IUserInfoRepository),typeof(EfCoreUserInfoRepository));
        return services;
    }

    public static ModelBuilder ConfigureSimple(this ModelBuilder builder)
    {
        builder.Entity<UserInfo>(x =>
        {
            x.ToTable("UserInfos");

            x.HasIndex(info => info.Id);
        });
        
        return builder;
    }
}