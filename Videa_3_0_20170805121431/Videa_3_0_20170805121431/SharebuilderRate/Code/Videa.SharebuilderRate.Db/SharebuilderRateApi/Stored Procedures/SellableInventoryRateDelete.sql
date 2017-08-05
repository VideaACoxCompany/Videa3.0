CREATE PROCEDURE SharebuilderRateApi.SellableInventoryRateDelete
@SellableInventoryRateHashKey CHAR (32)
AS
DELETE [SharebuilderRate].[SellableInventoryRate]
WHERE  SellableInventoryRateHashKey = @SellableInventoryRateHashKey;