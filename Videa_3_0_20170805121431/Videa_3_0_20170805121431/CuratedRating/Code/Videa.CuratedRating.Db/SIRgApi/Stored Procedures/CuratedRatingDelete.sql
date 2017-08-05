CREATE PROCEDURE SIRgApi.CuratedRatingDelete
@CuratedRatingId BIGINT
AS
DELETE [SIRg].[CuratedRating]
WHERE  CuratedRatingId = @CuratedRatingId;