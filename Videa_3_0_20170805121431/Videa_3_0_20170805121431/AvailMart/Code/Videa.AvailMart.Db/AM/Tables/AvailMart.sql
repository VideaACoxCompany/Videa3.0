CREATE TABLE [AM].[AvailMart] (
    [AvailMartHashKey] CHAR (32)     NOT NULL,
    [AvailMartSqn]     INT           IDENTITY (1000, 1) NOT NULL,
    [StartDate]        DATETIME2 (7) NOT NULL,
    [EndDate]          DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_AM_AvailMart_AvailMartHashKey] PRIMARY KEY CLUSTERED ([AvailMartHashKey] ASC)
);

