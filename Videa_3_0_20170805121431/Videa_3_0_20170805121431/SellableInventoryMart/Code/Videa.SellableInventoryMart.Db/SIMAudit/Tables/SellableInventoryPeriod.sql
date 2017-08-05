CREATE TABLE [SIMAudit].[SellableInventoryPeriod] (
    [SellableInventoryPeriodHashKey]   CHAR (32)     NOT NULL UNIQUE NONCLUSTERED ([SellableInventoryPeriodHashKey] ASC),
    [SellableInventoryPeriodSqn]       INT           IDENTITY (1000, 1) NOT NULL,
    [SellableInventoryPeriodName]      VARCHAR (255) NOT NULL,
    [SellableInventoryPeriodStartDate] DATETIME2 (7) NOT NULL,
    [SellableInventoryPeriodEndDate]   DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_SIMAudit_SellableInventoryPeriod_SellableInventoryPeriodHashKey] PRIMARY KEY CLUSTERED ([SellableInventoryPeriodHashKey] ASC)
);

