FROM registry.cn-shenzhen.aliyuncs.com/tokengo/dotnet-aspnet:6.0-alpine AS base
WORKDIR /app
EXPOSE 80

FROM registry.cn-shenzhen.aliyuncs.com/tokengo/dotnet-sdk:6.0-alpine AS build
WORKDIR /src
COPY ["src/Simple.HttpApi.Host/Simple.HttpApi.Host.csproj", "src/Simple.HttpApi.Host/"]
COPY ["src/Simple.Application/Simple.Application.csproj", "src/Simple.Application/"]
COPY ["src/Simple.Application.Contract/Simple.Application.Contract.csproj", "src/Simple.Application.Contract/"]
COPY ["src/Simple.Domain/Simple.Domain.csproj", "src/Simple.Domain/"]
COPY ["src/Simple.Domain.Shared/Simple.Domain.Shared.csproj", "src/Simple.Domain.Shared/"]
COPY ["src/Simple.EntityFrameworkCore/Simple.EntityFrameworkCore.csproj", "src/Simple.EntityFrameworkCore/"]
COPY ["src/efcore/EntityFrameworkCore.Mysql/EntityFrameworkCore.Mysql.csproj", "src/efcore/EntityFrameworkCore.Mysql/"]
COPY ["src/efcore/EntityFrameworkCore/EntityFrameworkCore.csproj", "src/efcore/EntityFrameworkCore/"]
COPY ["src/module/Simple.Common.Jwt/Simple.Common.Jwt.csproj", "src/module/Simple.Common.Jwt/"]
RUN dotnet restore "src/Simple.HttpApi.Host/Simple.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/Simple.HttpApi.Host"
RUN dotnet build "Simple.HttpApi.Host.csproj" -c Release --os linux -o /app/build

FROM build AS publish
RUN dotnet publish "Simple.HttpApi.Host.csproj" -c Release --os linux -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Simple.HttpApi.Host.dll"]