CREATE PROCEDURE SellerRating.GetSellerRatingsByInventoryKeys
@SellableInventoryList ttSellableInventory READONLY
AS
SELECT SellableInventoryHashKey,
       SellableInventoryRatingHashKey,
       RatingDemoHashKey,
       SellableInventoryRatingValue
FROM   [SellerRating].[SellableInventoryRating]
WHERE  SellableInventoryHashKey IN (SELECT [SellableInventoryHashKey]
                                    FROM   @SellableInventoryList);