CREATE PROCEDURE SellerRateApi.RatePeriodDelete
@RatePeriodHashKey CHAR (32)
AS
DELETE [SellerRate].[RatePeriod]
WHERE  RatePeriodHashKey = @RatePeriodHashKey;