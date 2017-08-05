CREATE PROCEDURE InventoryGuideApi.RateCardTypeDelete
@RateCardTypeHashKey CHAR (32)
AS
DELETE [InventoryGuide].[RateCardType]
WHERE  RateCardTypeHashKey = @RateCardTypeHashKey;