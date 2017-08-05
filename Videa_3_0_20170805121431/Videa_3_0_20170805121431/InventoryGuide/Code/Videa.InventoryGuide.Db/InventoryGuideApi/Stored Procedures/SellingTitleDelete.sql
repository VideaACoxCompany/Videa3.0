CREATE PROCEDURE InventoryGuideApi.SellingTitleDelete
@SellingTitleHashKey CHAR (32)
AS
DELETE [InventoryGuide].[SellingTitle]
WHERE  SellingTitleHashKey = @SellingTitleHashKey;