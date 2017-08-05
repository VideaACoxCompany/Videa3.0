CREATE PROCEDURE InventoryGuideApi.StationDelete
@StationHashKey CHAR (32)
AS
DELETE [InventoryGuide].[Station]
WHERE  StationHashKey = @StationHashKey;