CREATE PROCEDURE AMApi.AvailLineWithDetailedPeriodsDelete
@AvailLineWithDetailedPeriodsHashKey CHAR (32)
AS
DELETE [AM].[AvailLineWithDetailedPeriods]
WHERE  AvailLineWithDetailedPeriodsHashKey = @AvailLineWithDetailedPeriodsHashKey;