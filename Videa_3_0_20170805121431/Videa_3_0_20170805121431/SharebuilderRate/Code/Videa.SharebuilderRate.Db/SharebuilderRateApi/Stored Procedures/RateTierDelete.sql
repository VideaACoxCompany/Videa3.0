CREATE PROCEDURE SharebuilderRateApi.RateTierDelete
@RateTierHashKey CHAR (32)
AS
DELETE [SharebuilderRate].[RateTier]
WHERE  RateTierHashKey = @RateTierHashKey;