CREATE PROCEDURE InventoryGuideApi.RatePeriodDelete
@RatePeriodHashKey CHAR (32)
AS
DELETE [InventoryGuide].[RatePeriod]
WHERE  RatePeriodHashKey = @RatePeriodHashKey;