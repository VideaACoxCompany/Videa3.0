CREATE PROCEDURE InventoryGuideApi.StationGroupDelete
@StationGroupHashKey CHAR (32)
AS
DELETE [InventoryGuide].[StationGroup]
WHERE  StationGroupHashKey = @StationGroupHashKey;