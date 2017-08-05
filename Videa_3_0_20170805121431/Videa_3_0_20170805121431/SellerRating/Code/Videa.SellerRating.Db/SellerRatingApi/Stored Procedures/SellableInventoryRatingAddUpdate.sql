CREATE PROCEDURE SellerRatingApi.SellableInventoryRatingAddUpdate
@SellableInventoryRatingHashKey CHAR (32), @SellableInventoryHashKey CHAR (32), @SellableInventoryRatingSqn INT, @RatingDemoHashKey CHAR (32), @RatingPeriodHashKey CHAR (32), @SellableInventoryRatingValue DECIMAL, @RowVersion TIMESTAMP=NULL
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action                         VARCHAR (20),
    SellableInventoryRatingHashKey CHAR (32)   ,
    RowVersion                     BINARY (8)  );
MERGE INTO [SellerRating].[SellableInventoryRating] WITH (HOLDLOCK)
 AS T
USING (SELECT @SellableInventoryRatingHashKey AS SellableInventoryRatingHashKey,
              @SellableInventoryHashKey AS SellableInventoryHashKey,
              @SellableInventoryRatingSqn AS SellableInventoryRatingSqn,
              @RatingDemoHashKey AS RatingDemoHashKey,
              @RatingPeriodHashKey AS RatingPeriodHashKey,
              @SellableInventoryRatingValue AS SellableInventoryRatingValue,
              @RowVersion AS RowVersion) AS NEW_T ON T.SellableInventoryRatingHashKey = NEW_T.SellableInventoryRatingHashKey
WHEN MATCHED AND (NEW_T.RowVersion IS NULL
                  OR T.RowVersion = NEW_T.RowVersion) THEN UPDATE 
SET T.SellableInventoryHashKey     = NEW_T.SellableInventoryHashKey,
    T.RatingDemoHashKey            = NEW_T.RatingDemoHashKey,
    T.RatingPeriodHashKey          = NEW_T.RatingPeriodHashKey,
    T.SellableInventoryRatingValue = NEW_T.SellableInventoryRatingValue,
    T.ModifiedDateUtc              = GetUtcDate()
WHEN NOT MATCHED AND NEW_T.SellableInventoryRatingHashKey = 0
                     AND NEW_T.RowVersion IS NULL THEN INSERT (SellableInventoryRatingHashKey, SellableInventoryHashKey, RatingDemoHashKey, RatingPeriodHashKey, SellableInventoryRatingValue, CreatedDateUtc, ModifiedDateUtc) VALUES (NEW_T.SellableInventoryRatingHashKey, NEW_T.SellableInventoryHashKey, NEW_T.RatingDemoHashKey, NEW_T.RatingPeriodHashKey, NEW_T.SellableInventoryRatingValue, GetUtcDate(), NULL)
OUTPUT $ACTION, inserted.SellableInventoryRatingHashKey AS 'SellableInventoryRatingHashKey', inserted.RowVersion AS 'RowVersion' INTO @Output;
SELECT Action,
       SellableInventoryRatingHashKey,
       RowVersion
FROM   @Output;