CREATE PROCEDURE SIMApi.SellableInventoryDelete
@SellableInventoryHashKey CHAR (32)
AS
DELETE [SIM].[SellableInventory]
WHERE  SellableInventoryHashKey = @SellableInventoryHashKey;