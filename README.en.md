# SimpleFramework



-----

The document language: [[English] (README. En. Md)] | [[simplified Chinese] (README. Md)]



# # 🎈 is introduced

Simplified framework encapsulates EFcore warehousing, work units

Clear frame structure



# # 🎞 ️ project structure



/src // Project folder



/src/Simple.DbMigrations // Migrate file management projects



. / SRC/Simple EntityFrameworkCore / / warehousing implementation in the field of current and Dbcontext



/ SRC/Simple. Application. Contract / / Contract



/src/ simp. Application // Business layer



/src/efcore // Some EfCore packaging for the framework



/ SRC/efcore EfCoreEntityFrameworkCore / / efcore based encapsulation



. / SRC/efcore/EfCoreEntityFrameworkCore DbMigrations / / project all efcore migration file storage



. / SRC/efcore EfCoreEntityFrameworkCore/Mysql / / Mysql database module implementation



/ SRC/efcore/EfCoreEntityFrameworkCore. Essentially a / / used database module implementation



. / SRC/efcore/EfCoreEntityFrameworkCore Sqlite / / Sqlite database module implementation



/src/auth // Licensing service (standalone deployment)





## 🍬 Basic functions

1. Implement the basic soft delete function

2. Implement the creator to delete the person and update the person assignment

3. Implement tenant functions (not tested)

4. Implement basic authorization services

5. Implement basic user functions



## 🏴‍☠️ Build the project



Build the Docker image that packages the Simple project

```shell
docker build -f ./src/Simple.HttpApi.Host/Dockerfile -t simple .
```

Build the Docker image that packages the Simple-Auth project

```shell
docker build -f ./src/auth/Simple.Auth.HttpApi.Host/Dockerfile -t auth .
```



## 🛞instructions

***First you need to modify the appsettings.json mysql database connection string under the simply.httpapi.host, simply.dbmigrations, simply.auth.httpapi.host project*** 



***Generate the migration file at Simple.DbMigrations and then update the migration file***

# SimpleFramework



-----

The document language: [[English] (README. En. Md)] | [[simplified Chinese] (README. Md)]



## 🎈 is introduced

Simplified framework encapsulates EFcore warehousing, work units

Clear frame structure



## 🎞 ️ project structure

/src // Project folder

/src/Simple.DbMigrations // Migrate file management projects

. / SRC/Simple EntityFrameworkCore / / warehousing implementation in the field of current and Dbcontext

/ SRC/Simple. Application. Contract / / Contract

/src/ simp. Application // Business layer

/src/efcore // Some EfCore packaging for the framework

/ SRC/efcore EfCoreEntityFrameworkCore / / efcore based encapsulation

. / SRC/efcore/EfCoreEntityFrameworkCore DbMigrations / / project all efcore migration file storage

. / SRC/efcore EfCoreEntityFrameworkCore/Mysql / / Mysql database module implementation

/ SRC/efcore/EfCoreEntityFrameworkCore. Essentially a / / used database module implementation

. / SRC/efcore/EfCoreEntityFrameworkCore Sqlite / / Sqlite database module implementation

/src/auth // Licensing service (standalone deployment)

## 🍬 Basic functions

1. Implement the basic soft delete function

2. Implement the creator to delete the person and update the person assignment

3. Implement tenant functions (not tested)

4. Implement basic authorization services

5. Implement basic user functions

## 🏴‍☠️ Build the project

Build the Docker image that packages the Simple project

```shell

docker build -f ./src/Simple.HttpApi.Host/Dockerfile -t simple .

```



Build the Docker image that packages the Simple-Auth project

```shell

docker build -f ./src/auth/Simple.Auth.HttpApi.Host/Dockerfile -t auth .

```



## 🛞 instructions



***First you need to modify the appsettings.json mysql database connection string under the simply.httpapi.host, simply.dbmigrations, simply.auth.httpapi.host project*** 



***Generate the migration file at Simple.DbMigrations and then update the migration file***

 