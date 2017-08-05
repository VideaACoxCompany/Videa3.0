CREATE PROCEDURE AMApi.AvailListDelete
@AvailListHashKey CHAR (32)
AS
DELETE [AM].[AvailList]
WHERE  AvailListHashKey = @AvailListHashKey;