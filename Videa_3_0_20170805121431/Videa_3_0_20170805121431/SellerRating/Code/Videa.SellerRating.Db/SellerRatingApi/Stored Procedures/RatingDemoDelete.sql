CREATE PROCEDURE SellerRatingApi.RatingDemoDelete
@RatingDemoHashKey CHAR (32)
AS
DELETE [SellerRating].[RatingDemo]
WHERE  RatingDemoHashKey = @RatingDemoHashKey;