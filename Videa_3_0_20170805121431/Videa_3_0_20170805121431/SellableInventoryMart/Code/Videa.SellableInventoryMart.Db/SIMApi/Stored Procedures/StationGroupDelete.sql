CREATE PROCEDURE SIMApi.StationGroupDelete
@StationGroupHashKey CHAR (32)
AS
DELETE [SIM].[StationGroup]
WHERE  StationGroupHashKey = @StationGroupHashKey;