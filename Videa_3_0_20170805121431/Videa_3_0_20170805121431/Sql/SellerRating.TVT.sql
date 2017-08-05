
CREATE TYPE [SellerRating].[ttSellableInventory] AS 
    TABLE(	[SellableInventoryHashKey] char(32) NOT NULL)

	
	
CREATE TYPE [SellerRating].[ttSellableInventoryRating] AS 
    TABLE(	[SellableInventoryRatingHashKey] char(32) NOT NULL)