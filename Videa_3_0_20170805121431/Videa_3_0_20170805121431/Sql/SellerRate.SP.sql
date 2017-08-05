CREATE PROCEDURE [SellerRate].GetSellerRatesByInventoryKeys
(
@SellableInventoryList ttSellableInventory READONLY
)
AS
    SELECT 
 SellableInventoryHashKey,
 SellableInventoryRateHashKey,
 RateTierHashKey,
 SellableInventoryRateValue
 FROM [SellerRate].[SellableInventoryRate]
 WHERE SellableInventoryHashKey in (SELECT [SellableInventoryHashKey] FROM @SellableInventoryList)


go

CREATE PROCEDURE [SellerRate].GetSellerRatesByRateKeys
(
@SellableInventoryRateList [ttSellableInventoryRate] READONLY
)
AS
    SELECT
 SellableInventoryRateHashKey,
 RateTierHashKey,
 SellableInventoryRateValue,
 CONVERT(char(32),'') AS RatePeriodHashKey
 FROM [SellerRate].[SellableInventoryRate]
 WHERE SellableInventoryRateHashKey in (SELECT SellableInventoryRateHashKey FROM @SellableInventoryRateList)