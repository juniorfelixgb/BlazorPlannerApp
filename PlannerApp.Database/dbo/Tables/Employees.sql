CREATE TABLE [dbo].[Employees] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (MAX) NULL,
    [LastName]    NVARCHAR (MAX) NULL,
    [Email]       NVARCHAR (MAX) NULL,
    [PhoneNumber] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([Id] ASC)
);

