CREATE TABLE [SellerRatingAudit].[SellableInventoryRating] (
    [SellableInventoryRatingHashKey] CHAR (32)     NOT NULL,
    [SellableInventoryHashKey]       CHAR (32)     NOT NULL,
    [SellableInventoryRatingSqn]     INT           IDENTITY (1000, 1) NOT NULL,
    [RatingDemoHashKey]              CHAR (32)     NOT NULL,
    [RatingPeriodHashKey]            CHAR (32)     NOT NULL,
    [SellableInventoryRatingValue]   DECIMAL (18)  NOT NULL,
    [RowVersion]                     TIMESTAMP     NOT NULL,
    [CreatedDateUtc]                 DATETIME2 (7) NOT NULL,
    [ModifiedDateUtc]                DATETIME2 (7) NULL,
    CONSTRAINT [PK_SellerRatingAudit_SellableInventoryRating_SellableInventoryRatingHashKey] PRIMARY KEY CLUSTERED ([SellableInventoryRatingHashKey] ASC),
    FOREIGN KEY ([RatingDemoHashKey]) REFERENCES [SellerRating].[RatingDemo] ([RatingDemoHashKey]),
    FOREIGN KEY ([RatingPeriodHashKey]) REFERENCES [SellerRating].[RatingPeriod] ([RatingPeriodHashKey])
);

