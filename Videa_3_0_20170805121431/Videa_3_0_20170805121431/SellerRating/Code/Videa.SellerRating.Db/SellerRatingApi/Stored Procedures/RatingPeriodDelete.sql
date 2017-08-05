CREATE PROCEDURE SellerRatingApi.RatingPeriodDelete
@RatingPeriodHashKey CHAR (32)
AS
DELETE [SellerRating].[RatingPeriod]
WHERE  RatingPeriodHashKey = @RatingPeriodHashKey;