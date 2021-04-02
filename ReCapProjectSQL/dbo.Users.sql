CREATE TABLE [dbo].[Users]
(
	[UserId]	INT IDENTITY (1, 1) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName]  NVARCHAR(50) NOT NULL, 
    [Email]		NVARCHAR(50) NOT NULL, 
    [Password]  NVARCHAR(50) NOT NULL,
	PRIMARY KEY CLUSTERED ([UserId] ASC)
)
