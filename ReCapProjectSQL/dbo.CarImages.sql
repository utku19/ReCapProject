CREATE TABLE [dbo].[CarImages] (
    [CarImageId] INT IDENTITY (1, 1) NOT NULL,
    [CarId]      INT				NOT NULL,
    [ImagePath]  NVARCHAR (MAX)		NOT NULL,
    [ImageDate]  DATETIME			NOT NULL,
    PRIMARY KEY  CLUSTERED ([CarImageId] ASC),
    FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([CarId])
);

