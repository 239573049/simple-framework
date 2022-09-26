# SimpleFramework

-----
document language: [[English](README.en.md)] |[[简体中文](README.md)]

## 🎈brief introduction
Simplified framework, encapsulates the EFcore warehouse, work unit
The frame structure is clear

## 🎞project structure

./src                                        // Project Folder

 --/src/Simple.DbMigrations                 // Migrate the file management project

 --/src/Simple.EntityFrameworkCore          // Repository implementation and Dbcontext for the current domain

 --/src/Simple.Application.Contract         // contract

 --/src/Simple.Application                  // Business Logic Layer

 --/src/efcore                              // Some EntityFrameworkCore encapsulation of the framework

 --/src/efcore/EfCoreEntityFrameworkCore                // EntityFrameworkCoreBased on packaging

 --/src/efcore/EfCoreEntityFrameworkCore.DbMigrations   // All EntityFrameworkCore migration files of the project are stored

 --/src/efcore/EfCoreEntityFrameworkCore.Mysql   // Mysql module implementation
 
 --/src/efcore/EfCoreEntityFrameworkCore.SqlServer   // SqlServer module implementation
 
## 🍬basic function
1. Implements the basic soft delete function 
2. Implement creator delete person update person assignment
3. Implementing tenant functionality (not tested)
4. Implement basic authorization services
5. Implement basic user functions