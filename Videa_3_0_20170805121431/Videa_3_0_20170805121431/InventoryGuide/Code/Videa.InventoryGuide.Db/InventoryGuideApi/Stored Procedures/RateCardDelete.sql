CREATE PROCEDURE InventoryGuideApi.RateCardDelete
@RateCardHashKey CHAR (32)
AS
DELETE [InventoryGuide].[RateCard]
WHERE  RateCardHashKey = @RateCardHashKey;