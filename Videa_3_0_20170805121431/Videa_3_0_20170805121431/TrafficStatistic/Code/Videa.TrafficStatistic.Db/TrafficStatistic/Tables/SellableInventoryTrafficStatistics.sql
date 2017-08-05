CREATE TABLE [TrafficStatistic].[SellableInventoryTrafficStatistics] (
    [SellableInventoryTrafficStatisticHashKey] CHAR (32)     NOT NULL,
    [SellableInventoryHashKey]                 CHAR (32)     NOT NULL,
    [SellableInventoryTrafficStatisticSqn]     INT           IDENTITY (1000, 1) NOT NULL,
    [SellableInventoryAURValue]                MONEY         NOT NULL,
    [RowVersion]                               TIMESTAMP     NOT NULL,
    [CreatedDateUtc]                           DATETIME2 (7) NOT NULL,
    [ModifiedDateUtc]                          DATETIME2 (7) NULL,
    CONSTRAINT [PK_TrafficStatistic_SellableInventoryTrafficStatistics_SellableInventoryTrafficStatisticHashKey] PRIMARY KEY CLUSTERED ([SellableInventoryTrafficStatisticHashKey] ASC)
);

