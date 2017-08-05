CREATE TABLE [AM].[AvailList] (
    [AvailListHashKey] CHAR (32)     NOT NULL,
    [AvailListSqn]     INT           IDENTITY (1000, 1) NOT NULL,
    [AvailMartHashKey] CHAR (32)     NOT NULL,
    [Name]             VARCHAR (255) NOT NULL,
    [StartDate]        DATETIME2 (7) NOT NULL,
    [EndDate]          DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_AM_AvailList_AvailListHashKey] PRIMARY KEY CLUSTERED ([AvailListHashKey] ASC),
    FOREIGN KEY ([AvailMartHashKey]) REFERENCES [AvailMart].[AvailMart] ([AvailMartHashKey])
);

