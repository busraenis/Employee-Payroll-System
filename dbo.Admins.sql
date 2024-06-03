CREATE TABLE [dbo].[Admins] (
    [AdminID]  INT           IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (50) NULL,
    [Password] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([AdminID] ASC)
);

