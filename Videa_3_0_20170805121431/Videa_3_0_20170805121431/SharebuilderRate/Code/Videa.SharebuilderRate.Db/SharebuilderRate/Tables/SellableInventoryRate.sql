CREATE TABLE [SharebuilderRate].[SellableInventoryRate] (
    [SellableInventoryRateHashKey] CHAR (32)     NOT NULL,
    [SellableInventoryHashKey]     CHAR (32)     NOT NULL,
    [SellableInventoryRateSqn]     INT           IDENTITY (1000, 1) NOT NULL,
    [RateTierHashKey]              CHAR (32)     NOT NULL,
    [SellableInventoryRateValue]   MONEY         NOT NULL,
    [RowVersion]                   TIMESTAMP     NOT NULL,
    [CreatedDateUtc]               DATETIME2 (7) NOT NULL,
    [ModifiedDateUtc]              DATETIME2 (7) NULL,
    CONSTRAINT [PK_SharebuilderRate_SellableInventoryRate_SellableInventoryRateHashKey] PRIMARY KEY CLUSTERED ([SellableInventoryRateHashKey] ASC),
    FOREIGN KEY ([RateTierHashKey]) REFERENCES [SharebuilderRate].[RateTier] ([RateTierHashKey])
);

