CREATE PROCEDURE AMApi.AvailMartDelete
@AvailMartHashKey CHAR (32)
AS
DELETE [AM].[AvailMart]
WHERE  AvailMartHashKey = @AvailMartHashKey;