# ðï¸**è¿ç§»æ§å¶å°ç¨åº**

**å½åé¡¹ç®ä»ç¨æ¥è¿ç§»æ°æ®åºç»æ**

å¦æå­å¨è¿ç§»è®°å½å¯ä»¥å¯å¨ç¨åºæ´æ°æ°æ®åºç»æ

## çæ Simple åºçè¿ç§»æä»¶ ï¼éå° Init ä¿®æ¹ä¸ºå®éçæ¹å¨åå­ï¼

```shell
dotnet ef migrations add Init --project ../efcore/EntityFrameworkCore.DbMigrations --context EfCoreMigrationDbContext 
```

## æ§è¡åºçæè¿ä¸æ¬¡è¿ç§»

```shell
dotnet ef database update --project ../efcore/EntityFrameworkCore.DbMigrations --context EfCoreMigrationDbContext
```

## æ¤éä¸æ¬¡è¿ç§»(-f è¡¨ç¤ºå¼ºå¶)
```shell
dotnet ef migrations remove -f --project ../efcore/EntityFrameworkCore.DbMigrations --context EfCoreMigrationDbContext
```

## çææ¬æ¬¡è¿ç§»çå¹ç­SQLèæ¬ï¼éåçäº§ç¯å¢ï¼
## åèï¼ https://docs.microsoft.com/zh-cn/ef/core/managing-schemas/migrations/applying?tabs=dotnet-core-cli#idempotent-sql-scripts

```shell
dotnet ef migrations script --idempotent --project ../efcore/EntityFrameworkCore.DbMigrations --context EfCoreMigrationDbContext


```

```shell
dotnet ef migrations script name --project ../efcore/EntityFrameworkCore.DbMigrations --context EfCoreMigrationDbContext
```