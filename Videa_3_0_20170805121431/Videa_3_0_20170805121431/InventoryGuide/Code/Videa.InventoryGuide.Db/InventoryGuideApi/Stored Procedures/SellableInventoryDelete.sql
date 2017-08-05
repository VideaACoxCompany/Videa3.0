CREATE PROCEDURE InventoryGuideApi.SellableInventoryDelete
@SellableInventoryHashKey CHAR (32)
AS
DELETE [InventoryGuide].[SellableInventory]
WHERE  SellableInventoryHashKey = @SellableInventoryHashKey;