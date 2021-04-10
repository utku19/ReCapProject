CREATE TABLE [dbo].[Users] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50) NOT NULL,
    [LastName]  VARCHAR (50) NOT NULL,
    [Email]     VARCHAR (50) NOT NULL,
    [PasswordHash]  BINARY(500) NOT NULL,
    [PasswordSalt] BINARY(500) NOT NULL, 
    [Status] BIT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);