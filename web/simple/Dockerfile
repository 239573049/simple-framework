# 如果使用根目录的compose文件build的话不需要修改
# 如果直接在当前目录build请修改参数 web/simple => ./ 

FROM nginx:stable-alpine AS base
WORKDIR /app
EXPOSE 80

FROM node:lts-alpine3.15 AS build
WORKDIR /src
COPY web/Simple/ .
WORKDIR "/src"
RUN npm config set registry https://registry.npm.taobao.org
RUN npm i
RUN npm run build

FROM base AS final
WORKDIR /app
COPY --from=build /src/build /wwwroot/
COPY web/Simple/conf.d/ /etc/nginx/conf.d/ 