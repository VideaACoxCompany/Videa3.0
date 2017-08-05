CREATE PROCEDURE SIMApi.RateCardDelete
@RateCardHashKey CHAR (32)
AS
DELETE [SIM].[RateCard]
WHERE  RateCardHashKey = @RateCardHashKey;