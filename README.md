# SimpleFramework

-----
文档语言: [[English](README.en.md)] | [[简体中文](README.md)]

## 🎈介绍
简化框架，封装了EFcore仓储，工作单元
框架结构分明

## 🎞️项目结构

./src                                        // 项目文件夹

 --/src/Simple.DbMigrations                 // 迁移文件管理项目

 --/src/Simple.EntityFrameworkCore          // 当前领域的仓储实现和Dbcontext 

 --/src/Simple.Application.Contract         // 契约

 --/src/Simple.Application                  // 业务层

 --/src/efcore                              // 框架的一些EfCore封装

 --/src/efcore/EfCoreEntityFrameworkCore                // EfCore基础封装

 --/src/efcore/EfCoreEntityFrameworkCore.DbMigrations   // 项目所有EfCore迁移文件存放

 --/src/efcore/EfCoreEntityFrameworkCore.Mysql   // Mysql模块实现
 
 --/src/efcore/EfCoreEntityFrameworkCore.SqlServer   // SqlServer模块实现
 
## 🍬基本功能
1. 实现基本软删功能 
2. 实现创建人删除人更新人赋值
3. 实现租户功能（未测试）
4. 实现基本的授权服务
5. 实现基本用户功能