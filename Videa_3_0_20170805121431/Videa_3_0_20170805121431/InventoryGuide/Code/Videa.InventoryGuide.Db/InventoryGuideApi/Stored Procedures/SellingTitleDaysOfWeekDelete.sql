CREATE PROCEDURE InventoryGuideApi.SellingTitleDaysOfWeekDelete
@SellingTitleDaysOfWeekHashKey CHAR (32)
AS
DELETE [InventoryGuide].[SellingTitleDaysOfWeek]
WHERE  SellingTitleDaysOfWeekHashKey = @SellingTitleDaysOfWeekHashKey;