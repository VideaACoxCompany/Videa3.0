﻿CREATE TABLE [InventoryGuide].[SellingTitle] (
    [SellingTitleHashKey]   CHAR (32)     NOT NULL UNIQUE NONCLUSTERED ([SellingTitleHashKey] ASC),
    [SellingTitleSqn]       INT           IDENTITY (1000, 1) NOT NULL,
    [SellingTitleName]      VARCHAR (255) NOT NULL,
    [SellingTitleStartDate] DATETIME2 (7) NOT NULL,
    [SellingTitleEndDate]   DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_InventoryGuide_SellingTitle_SellingTitleHashKey] PRIMARY KEY CLUSTERED ([SellingTitleHashKey] ASC)
);

