 CREATE PROCEDURE [SIRgApi].[GetConfirmedRatings]
        (
            @SellableInventoryList ttSellableInventory READONLY
        )
        AS
            SELECT SellableInventoryHashKey,
			RatingHashKey
			FROM [SIRgApi].[CuratedRating] 
			where SellableInventoryHashKey in (select SellableInventoryHashKey from @SellableInventoryList)