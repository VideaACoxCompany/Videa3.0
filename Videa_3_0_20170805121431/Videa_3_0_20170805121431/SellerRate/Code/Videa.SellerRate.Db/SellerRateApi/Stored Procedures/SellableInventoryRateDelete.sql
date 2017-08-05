CREATE PROCEDURE SellerRateApi.SellableInventoryRateDelete
@SellableInventoryRateHashKey CHAR (32)
AS
DELETE [SellerRate].[SellableInventoryRate]
WHERE  SellableInventoryRateHashKey = @SellableInventoryRateHashKey;