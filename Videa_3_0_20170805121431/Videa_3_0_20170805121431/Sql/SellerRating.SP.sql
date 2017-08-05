
CREATE PROCEDURE [SellerRating].GetSellerRatingsByInventoryKeys
(
@SellableInventoryList ttSellableInventory READONLY
)
AS
    SELECT 
 SellableInventoryHashKey,
 SellableInventoryRatingHashKey,
 RatingDemoHashKey,
 SellableInventoryRatingValue
 FROM [SellerRating].[SellableInventoryRating]
 WHERE SellableInventoryHashKey in (SELECT [SellableInventoryHashKey] FROM @SellableInventoryList)


go

CREATE PROCEDURE [SellerRating].GetSellerRatingsByRatingKeys
(
@SellableInventoryRatingList [ttSellableInventoryRating] READONLY
)
AS
    SELECT
 SellableInventoryRatingHashKey,
 RatingDemoHashKey,
 SellableInventoryRatingValue,
 CONVERT(char(32),'') AS RatingPeriodHashKey
 FROM [SellerRating].[SellableInventoryRating]
 WHERE SellableInventoryRatingHashKey in (SELECT SellableInventoryRatingHashKey FROM @SellableInventoryRatingList)