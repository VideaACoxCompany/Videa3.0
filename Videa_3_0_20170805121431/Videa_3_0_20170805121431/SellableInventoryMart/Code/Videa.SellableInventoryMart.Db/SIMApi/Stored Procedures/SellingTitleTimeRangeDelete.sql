CREATE PROCEDURE SIMApi.SellingTitleTimeRangeDelete
@SellingTitleTimeRangeHashKey CHAR (32)
AS
DELETE [SIM].[SellingTitleTimeRange]
WHERE  SellingTitleTimeRangeHashKey = @SellingTitleTimeRangeHashKey;