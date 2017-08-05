CREATE PROCEDURE SIMApi.SellableInventoryPeriodDelete
@SellableInventoryPeriodHashKey CHAR (32)
AS
DELETE [SIM].[SellableInventoryPeriod]
WHERE  SellableInventoryPeriodHashKey = @SellableInventoryPeriodHashKey;