CREATE PROCEDURE SIMApi.StationDelete
@StationHashKey CHAR (32)
AS
DELETE [SIM].[Station]
WHERE  StationHashKey = @StationHashKey;