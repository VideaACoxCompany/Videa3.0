CREATE PROCEDURE SIMApi.RateCardTypeDelete
@RateCardTypeHashKey CHAR (32)
AS
DELETE [SIM].[RateCardType]
WHERE  RateCardTypeHashKey = @RateCardTypeHashKey;