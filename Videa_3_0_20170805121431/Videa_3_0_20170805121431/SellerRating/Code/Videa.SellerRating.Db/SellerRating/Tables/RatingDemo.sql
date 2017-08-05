CREATE TABLE [SellerRating].[RatingDemo] (
    [RatingDemoHashKey] CHAR (32)     NOT NULL,
    [RatingDemoSqn]     INT           NOT NULL,
    [RatingDemoName]    VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_SellerRating_RatingDemo_RatingDemoHashKey] PRIMARY KEY CLUSTERED ([RatingDemoHashKey] ASC)
);

