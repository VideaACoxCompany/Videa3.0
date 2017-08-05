CREATE PROCEDURE SIMApi.RateCardDaypartDelete
@RateCardDaypartHashKey CHAR (32)
AS
DELETE [SIM].[RateCardDaypart]
WHERE  RateCardDaypartHashKey = @RateCardDaypartHashKey;