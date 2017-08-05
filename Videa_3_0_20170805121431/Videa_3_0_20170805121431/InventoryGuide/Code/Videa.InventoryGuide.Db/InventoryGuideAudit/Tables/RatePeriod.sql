CREATE TABLE [InventoryGuideAudit].[RatePeriod] (
    [RatePeriodHashKey]   CHAR (32)     NOT NULL UNIQUE NONCLUSTERED ([RatePeriodHashKey] ASC),
    [RatePeriodSqn]       INT           IDENTITY (1000, 1) NOT NULL,
    [RatePeriodName]      VARCHAR (255) NOT NULL,
    [RatePeriodStartDate] DATETIME2 (7) NOT NULL,
    [RatePeriodEndDate]   DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_InventoryGuideAudit_RatePeriod_RatePeriodHashKey] PRIMARY KEY CLUSTERED ([RatePeriodHashKey] ASC)
);

