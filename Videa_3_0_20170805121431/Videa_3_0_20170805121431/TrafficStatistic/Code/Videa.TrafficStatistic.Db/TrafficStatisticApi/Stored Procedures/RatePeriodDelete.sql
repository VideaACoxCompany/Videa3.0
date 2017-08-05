CREATE PROCEDURE TrafficStatisticApi.RatePeriodDelete
@RatePeriodHashKey CHAR (32)
AS
DELETE [TrafficStatistic].[RatePeriod]
WHERE  RatePeriodHashKey = @RatePeriodHashKey;