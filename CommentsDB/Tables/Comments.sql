CREATE TABLE [dbo].[Comments]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PageID] INT NULL, 
    [Nick] NVARCHAR(50) NULL, 
    [Text] NVARCHAR(MAX) NULL, 
    [Date] DATETIME NULL
)
