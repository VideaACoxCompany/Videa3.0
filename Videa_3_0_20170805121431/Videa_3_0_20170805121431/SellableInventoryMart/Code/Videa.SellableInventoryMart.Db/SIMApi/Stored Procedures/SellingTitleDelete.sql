CREATE PROCEDURE SIMApi.SellingTitleDelete
@SellingTitleHashKey CHAR (32)
AS
DELETE [SIM].[SellingTitle]
WHERE  SellingTitleHashKey = @SellingTitleHashKey;