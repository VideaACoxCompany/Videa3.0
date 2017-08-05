

	CREATE view [SellerRating].[RatingDemo] as
    SELECT  CONVERT(char(32),'') AS RatingDemoHashKey,
    1 as RatingDemoSqn,
    CONVERT(varchar(255),'') as RatingDemoName

GO

CREATE view [SellerRating].[RatingPeriod] as
    SELECT  CONVERT(char(32),'') AS RatingPeriodHashKey,
    1 as RatingPeriodSqn,
    CONVERT(varchar(255),'') as RatingPeriodName,
    CONVERT(datetime2,null) as RatingPeriodStartDate,
    CONVERT(datetime2,null) as RatingPeriodEndDate

GO

 CREATE view [SellerRating].[SellableInventoryRating] as
    SELECT  CONVERT(char(32),'') AS SellableInventoryRatingHashKey,
      CONVERT(char(32),'') AS SellableInventoryHashKey,
        1 as SellableInventoryRatingSqn,
     CONVERT(char(32),'') AS RatingDemoHashKey,
	 CONVERT(char(32),'') AS RatingPeriodHashKey,
        convert(decimal,0) as SellableInventoryRatingValue,
        convert(ROWVERSION, null) as RowVersion,
        convert(DateTime2, null) as CreatedDateUtc,
        convert(DateTime2, null) as ModifiedDateUtc

    GO