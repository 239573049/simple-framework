using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Token;
using Token.Extensions;

namespace Simple.Common.Jwt;

public class SimpleCommonJwtModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
        ConfigureAuthentication(services, services.GetConfiguration()!);
    }

    private void ConfigureAuthentication(IServiceCollection services, IConfiguration configuration)
    {
        var configurationSection = configuration.GetSection(nameof(TokenOptions));

        services.Configure<TokenOptions>(configurationSection);

        var tokenOptions = configurationSection.Get<TokenOptions>();
        if (string.IsNullOrEmpty(tokenOptions.Issuer))
            throw new Exception("未设置JWT权限配置");

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true, //是否在令牌期间验证签发者
                    ValidateAudience = true, //是否验证接收者
                    ValidateLifetime = true, //是否验证失效时间
                    ValidateIssuerSigningKey = true, //是否验证签名
                    ValidAudience = tokenOptions.Audience, //接收者
                    ValidIssuer = tokenOptions.Issuer, //签发者，签发的Token的人
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecretKey!)) // 密钥
                };
                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = (context) =>
                    {
                        // 添加signalr的token 因为signalr的token在请求头上所以需要设置
                        var accessToken = context.Request.Query["access_token"];
                        var path = context.HttpContext.Request.Path;
                        if (!string.IsNullOrEmpty(accessToken) &&
                            tokenOptions.SignalRUrl.Any(x => path.StartsWithSegments(x)))
                        {
                            context.Token = accessToken;
                        }

                        return Task.CompletedTask;
                    }
                };
            });
    }

    public override void OnApplicationShutdown(IApplicationBuilder app)
    {

        app.UseAuthentication();
        app.UseAuthorization();
    }
}