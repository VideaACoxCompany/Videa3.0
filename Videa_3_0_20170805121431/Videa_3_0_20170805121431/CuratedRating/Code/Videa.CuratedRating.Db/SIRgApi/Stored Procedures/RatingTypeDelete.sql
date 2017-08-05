CREATE PROCEDURE SIRgApi.RatingTypeDelete
@RatingTypeId INT
AS
DELETE [SIRg].[RatingType]
WHERE  RatingTypeId = @RatingTypeId;