CREATE TABLE [dbo].[Cars]
(
	[CarId]		  INT IDENTITY (1, 1) NOT NULL, 
    [BrandId]	  INT NOT NULL, 
    [ColorId]	  INT NOT NULL, 
    [ModelYear]	  INT NULL, 
    [DailyPrice]  DECIMAL NULL, 
    [Description] NVARCHAR(50) NULL, 
    [CarName]     NVARCHAR(50) NULL, 
	PRIMARY KEY CLUSTERED ([CarId] ASC),
    FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]), 
    FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId]) 
);
