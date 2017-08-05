CREATE TABLE [SellerRatingAudit].[RatingPeriod] (
    [RatingPeriodHashKey]   CHAR (32)     NOT NULL,
    [RatingPeriodSqn]       INT           NOT NULL,
    [RatingPeriodName]      VARCHAR (255) NOT NULL,
    [RatingPeriodStartDate] DATETIME2 (7) NOT NULL,
    [RatingPeriodEndDate]   DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_SellerRatingAudit_RatingPeriod_RatingPeriodHashKey] PRIMARY KEY CLUSTERED ([RatingPeriodHashKey] ASC)
);

