IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
CREATE TABLE [__EFMigrationsHistory] (
    [MigrationId] nvarchar(150) NOT NULL,
    [ProductVersion] nvarchar(32) NOT NULL,
    CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220830111631_init')
BEGIN
CREATE TABLE [UserInfos] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [UserName] nvarchar(max) NULL,
    [PassWord] nvarchar(max) NULL,
    [Avatar] nvarchar(max) NULL,
    [Status] int NOT NULL,
    [CreationTime] datetime2 NOT NULL,
    [LastModificationTime] datetime2 NULL,
    [LastModifierId] uniqueidentifier NULL,
    [IsDeleted] bit NOT NULL,
    [CreatorId] uniqueidentifier NULL,
    CONSTRAINT [PK_UserInfos] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220830111631_init')
BEGIN
CREATE INDEX [IX_UserInfos_Id] ON [UserInfos] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220830111631_init')
BEGIN
INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220830111631_init', N'6.0.0');
END;
GO

COMMIT;
GO


-- 初始化sql脚本