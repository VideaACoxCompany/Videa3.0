
CREATE TYPE [SellerRate].[ttSellableInventory] AS 
    TABLE(	[SellableInventoryHashKey] char(32) NOT NULL)

	
	
CREATE TYPE [SellerRate].[ttSellableInventoryRate] AS 
    TABLE(	[SellableInventoryRateHashKey] char(32) NOT NULL)