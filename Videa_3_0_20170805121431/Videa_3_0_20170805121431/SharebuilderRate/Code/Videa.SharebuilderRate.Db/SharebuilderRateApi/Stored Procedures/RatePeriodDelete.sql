CREATE PROCEDURE SharebuilderRateApi.RatePeriodDelete
@RatePeriodHashKey CHAR (32)
AS
DELETE [SharebuilderRate].[RatePeriod]
WHERE  RatePeriodHashKey = @RatePeriodHashKey;