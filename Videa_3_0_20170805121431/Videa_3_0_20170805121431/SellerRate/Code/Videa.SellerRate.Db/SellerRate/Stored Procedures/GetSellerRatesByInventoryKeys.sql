CREATE PROCEDURE SellerRate.GetSellerRatesByInventoryKeys
@SellableInventoryList ttSellableInventory READONLY
AS
SELECT SellableInventoryHashKey,
       SellableInventoryRateHashKey,
       RateTierHashKey,
       SellableInventoryRateValue
FROM   [SellerRate].[SellableInventoryRate]
WHERE  SellableInventoryHashKey IN (SELECT [SellableInventoryHashKey]
                                    FROM   @SellableInventoryList);