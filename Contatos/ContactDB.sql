CREATE TABLE [dbo].[People] (
    [ContactId] INT NOT NULL,
    [Name] NCHAR(100) NULL, 
    [Company] NCHAR(100) NULL, 
    [Telephone] NCHAR(100) NULL, 
    [Email] NCHAR(100) NULL, 
    [Client] BIT NULL, 
    [LastCall] DATETIME NULL, 
    PRIMARY KEY CLUSTERED ([ContactId] ASC)
);

