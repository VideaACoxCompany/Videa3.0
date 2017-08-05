CREATE TABLE [SellerRatingAudit].[RatingDemo] (
    [RatingDemoHashKey] CHAR (32)     NOT NULL,
    [RatingDemoSqn]     INT           NOT NULL,
    [RatingDemoName]    VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_SellerRatingAudit_RatingDemo_RatingDemoHashKey] PRIMARY KEY CLUSTERED ([RatingDemoHashKey] ASC)
);

