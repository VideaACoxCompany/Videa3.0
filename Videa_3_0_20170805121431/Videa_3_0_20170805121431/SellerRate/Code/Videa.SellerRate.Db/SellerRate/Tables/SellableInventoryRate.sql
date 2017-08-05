CREATE TABLE [SellerRate].[SellableInventoryRate] (
    [SellableInventoryRateHashKey] CHAR (32)     NOT NULL,
    [SellableInventoryHashKey]     CHAR (32)     NOT NULL,
    [SellableInventoryRateSqn]     INT           IDENTITY (1000, 1) NOT NULL,
    [RateTierHashKey]              CHAR (32)     NOT NULL,
    [RatePeriodHashKey]            CHAR (32)     NOT NULL,
    [SellableInventoryRateValue]   MONEY         NOT NULL,
    [RowVersion]                   TIMESTAMP     NOT NULL,
    [CreatedDateUtc]               DATETIME2 (7) NOT NULL,
    [ModifiedDateUtc]              DATETIME2 (7) NULL,
    CONSTRAINT [PK_SellerRate_SellableInventoryRate_SellableInventoryRateHashKey] PRIMARY KEY CLUSTERED ([SellableInventoryRateHashKey] ASC),
    FOREIGN KEY ([RatePeriodHashKey]) REFERENCES [SellerRate].[RatePeriod] ([RatePeriodHashKey]),
    FOREIGN KEY ([RateTierHashKey]) REFERENCES [SellerRate].[RateTier] ([RateTierHashKey])
);

