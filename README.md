# SimpleFramework

## 介绍
简化框架，封装了EFcore仓储，工作单元
框架结构分明

## 项目结构

./src                                        // 项目文件夹

 --./src/Simple.DbMigrations                 // 迁移文件管理项目

 --./src/Simple.EntityFrameworkCore          // 当前领域的仓储实现和Dbcontext 

 --./src/Simple.Application.Contract         // 契约

 --./src/Simple.Application                  // 业务层

 --./src/efcore                              // 框架的一些EfCore封装

 --./src/efcore/EfCoreEntityFrameworkCore                // EfCore封装

 --./src/efcore/EfCoreEntityFrameworkCore.DbMigrations   // 项目所有EfCore迁移文件存放
 
