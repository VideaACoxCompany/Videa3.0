CREATE PROCEDURE InventoryGuideApi.SellingTitleTimeRangeDelete
@SellingTitleTimeRangeHashKey CHAR (32)
AS
DELETE [InventoryGuide].[SellingTitleTimeRange]
WHERE  SellingTitleTimeRangeHashKey = @SellingTitleTimeRangeHashKey;