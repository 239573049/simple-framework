FROM registry.cn-shenzhen.aliyuncs.com/tokengo/dotnet-aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM registry.cn-shenzhen.aliyuncs.com/tokengo/dotnet-sdk:7.0 AS build
WORKDIR /src
COPY ["src/admin/Simple.Admin.HttpApi.Host/Simple.Admin.HttpApi.Host.csproj", "src/admin/Simple.Admin.HttpApi.Host/"]
COPY ["src/admin/Simple.Admin.Application/Simple.Admin.Application.csproj", "src/admin/Simple.Admin.Application/"]
COPY ["src/module/Simple.Common.Jwt/Simple.Common.Jwt.csproj", "src/module/Simple.Common.Jwt/"]
COPY ["src/Simple.Shared/Simple.Shared.csproj", "src/Simple.Shared/"]
COPY ["src/admin/Simple.Admin.Application.Contract/Simple.Admin.Application.Contract.csproj", "src/admin/Simple.Admin.Application.Contract/"]
COPY ["src/Simple.Application.Contract/Simple.Application.Contract.csproj", "src/Simple.Application.Contract/"]
COPY ["src/admin/Simple.Admin.Domain/Simple.Admin.Domain.csproj", "src/admin/Simple.Admin.Domain/"]
COPY ["src/Simple.Domain.Shared/Simple.Domain.Shared.csproj", "src/Simple.Domain.Shared/"]
COPY ["src/admin/Simple.Admin.EntityFrameworkCore/Simple.Admin.EntityFrameworkCore.csproj", "src/admin/Simple.Admin.EntityFrameworkCore/"]
COPY ["src/efcore/EntityFrameworkCore.SqlServer/EntityFrameworkCore.SqlServer.csproj", "src/efcore/EntityFrameworkCore.SqlServer/"]
COPY ["src/efcore/EntityFrameworkCore/EntityFrameworkCore.csproj", "src/efcore/EntityFrameworkCore/"]
RUN dotnet restore "src/admin/Simple.Admin.HttpApi.Host/Simple.Admin.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/admin/Simple.Admin.HttpApi.Host"
RUN dotnet build "Simple.Admin.HttpApi.Host.csproj" -c Release --os linux -o /app/build

FROM build AS publish
RUN dotnet publish "Simple.Admin.HttpApi.Host.csproj" -c Release --os linux -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Simple.Admin.HttpApi.Host.dll"]