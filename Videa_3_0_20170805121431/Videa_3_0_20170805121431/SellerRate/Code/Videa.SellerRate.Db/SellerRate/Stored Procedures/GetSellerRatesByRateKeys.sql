CREATE PROCEDURE SellerRate.GetSellerRatesByRateKeys
@SellableInventoryRateList ttSellableInventoryRate READONLY
AS
SELECT SellableInventoryRateHashKey,
       RateTierHashKey,
       SellableInventoryRateValue,
       CONVERT (CHAR (32), '') AS RatePeriodHashKey
FROM   [SellerRate].[SellableInventoryRate]
WHERE  SellableInventoryRateHashKey IN (SELECT SellableInventoryRateHashKey
                                        FROM   @SellableInventoryRateList);