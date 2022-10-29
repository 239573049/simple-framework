FROM registry.cn-shenzhen.aliyuncs.com/tokengo/dotnet-aspnet:6.0-alpine AS base
WORKDIR /app
EXPOSE 80

FROM registry.cn-shenzhen.aliyuncs.com/tokengo/dotnet-sdk:6.0-alpine AS build
WORKDIR /src
COPY ["src/auth/Simple.Auth.HttpApi.Host/Simple.Auth.HttpApi.Host.csproj", "src/auth/Simple.Auth.HttpApi.Host/"]
COPY ["src/auth/Simple.Auth.Application/Simple.Auth.Application.csproj", "src/auth/Simple.Auth.Application/"]
COPY ["src/module/Simple.Common.Jwt/Simple.Common.Jwt.csproj", "src/module/Simple.Common.Jwt/"]
COPY ["src/admin/Simple.Admin.Domain/Simple.Admin.Domain.csproj", "src/admin/Simple.Admin.Domain/"]
COPY ["src/Simple.Shared/Simple.Shared.csproj", "src/Simple.Shared/"]
COPY ["src/admin/Simple.Admin.Domain.Shared/Simple.Admin.Domain.Shared.csproj", "src/admin/Simple.Admin.Domain.Shared/"]
COPY ["src/auth/Simple.Auth.Application.Contract/Simple.Auth.Application.Contract.csproj", "src/auth/Simple.Auth.Application.Contract/"]
COPY ["src/auth/Simple.Auth.Domain/Simple.Auth.Domain.csproj", "src/auth/Simple.Auth.Domain/"]
COPY ["src/auth/Simple.Auth.EntityFrameworkCore/Simple.Auth.EntityFrameworkCore.csproj", "src/auth/Simple.Auth.EntityFrameworkCore/"]
COPY ["src/efcore/EntityFrameworkCore.Mysql/EntityFrameworkCore.Mysql.csproj", "src/efcore/EntityFrameworkCore.Mysql/"]
COPY ["src/efcore/EntityFrameworkCore/EntityFrameworkCore.csproj", "src/efcore/EntityFrameworkCore/"]
RUN dotnet restore "src/auth/Simple.Auth.HttpApi.Host/Simple.Auth.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/auth/Simple.Auth.HttpApi.Host"
RUN dotnet build "Simple.Auth.HttpApi.Host.csproj" -c Release --os linux -o /app/build

FROM build AS publish
RUN dotnet publish "Simple.Auth.HttpApi.Host.csproj" -c Release --os linux -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Simple.Auth.HttpApi.Host.dll"]