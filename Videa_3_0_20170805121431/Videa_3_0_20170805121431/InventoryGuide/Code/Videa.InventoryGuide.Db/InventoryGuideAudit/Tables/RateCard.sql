﻿CREATE TABLE [InventoryGuideAudit].[RateCard] (
    [RateCardHashKey]   CHAR (32)     NOT NULL UNIQUE NONCLUSTERED ([RateCardHashKey] ASC),
    [RateCardSqn]       INT           IDENTITY (1000, 1) NOT NULL,
    [RateCardName]      VARCHAR (255) NOT NULL,
    [RateCardStartDate] DATETIME2 (7) NOT NULL,
    [RateCardEndDate]   DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_InventoryGuideAudit_RateCard_RateCardHashKey] PRIMARY KEY CLUSTERED ([RateCardHashKey] ASC)
);

