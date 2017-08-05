CREATE PROCEDURE SellerRateApi.RateTierDelete
@RateTierHashKey CHAR (32)
AS
DELETE [SellerRate].[RateTier]
WHERE  RateTierHashKey = @RateTierHashKey;