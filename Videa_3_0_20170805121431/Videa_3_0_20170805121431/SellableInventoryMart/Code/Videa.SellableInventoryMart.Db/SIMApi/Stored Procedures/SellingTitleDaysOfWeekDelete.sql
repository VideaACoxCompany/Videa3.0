CREATE PROCEDURE SIMApi.SellingTitleDaysOfWeekDelete
@SellingTitleDaysOfWeekHashKey CHAR (32)
AS
DELETE [SIM].[SellingTitleDaysOfWeek]
WHERE  SellingTitleDaysOfWeekHashKey = @SellingTitleDaysOfWeekHashKey;