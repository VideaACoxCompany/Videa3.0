CREATE PROCEDURE SellerRating.GetSellerRatingsByRatingKeys
@SellableInventoryRatingList ttSellableInventoryRating READONLY
AS
SELECT SellableInventoryRatingHashKey,
       RatingDemoHashKey,
       SellableInventoryRatingValue,
       CONVERT (CHAR (32), '') AS RatingPeriodHashKey
FROM   [SellerRating].[SellableInventoryRating]
WHERE  SellableInventoryRatingHashKey IN (SELECT SellableInventoryRatingHashKey
                                          FROM   @SellableInventoryRatingList);