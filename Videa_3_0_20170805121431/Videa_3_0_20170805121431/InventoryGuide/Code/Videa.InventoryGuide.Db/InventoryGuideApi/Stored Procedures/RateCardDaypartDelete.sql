CREATE PROCEDURE InventoryGuideApi.RateCardDaypartDelete
@RateCardDaypartHashKey CHAR (32)
AS
DELETE [InventoryGuide].[RateCardDaypart]
WHERE  RateCardDaypartHashKey = @RateCardDaypartHashKey;