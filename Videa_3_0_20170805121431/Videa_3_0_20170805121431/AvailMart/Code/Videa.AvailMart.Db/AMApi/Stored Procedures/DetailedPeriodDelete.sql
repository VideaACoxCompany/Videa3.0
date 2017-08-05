CREATE PROCEDURE AMApi.DetailedPeriodDelete
@DetailedPeriodHashKey CHAR (32)
AS
DELETE [AM].[DetailedPeriod]
WHERE  DetailedPeriodHashKey = @DetailedPeriodHashKey;