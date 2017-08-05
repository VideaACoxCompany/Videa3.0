CREATE PROCEDURE SellerRatingApi.SellableInventoryRatingDelete
@SellableInventoryRatingHashKey CHAR (32)
AS
DELETE [SellerRating].[SellableInventoryRating]
WHERE  SellableInventoryRatingHashKey = @SellableInventoryRatingHashKey;