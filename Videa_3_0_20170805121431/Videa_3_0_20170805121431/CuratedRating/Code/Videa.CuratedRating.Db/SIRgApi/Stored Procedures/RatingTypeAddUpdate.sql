CREATE PROCEDURE SIRgApi.RatingTypeAddUpdate
@RatingTypeId INT, @RatingTypeName VARCHAR (64), @RatingTypeDescription VARCHAR (255)
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action       VARCHAR (20),
    RatingTypeId INT         );
MERGE INTO [SIRg].[RatingType] WITH (HOLDLOCK)
 AS T
USING (SELECT @RatingTypeId AS RatingTypeId,
              @RatingTypeName AS RatingTypeName,
              @RatingTypeDescription AS RatingTypeDescription) AS NEW_T ON T.RatingTypeId = NEW_T.RatingTypeId
WHEN MATCHED THEN UPDATE 
SET T.RatingTypeName        = NEW_T.RatingTypeName,
    T.RatingTypeDescription = NEW_T.RatingTypeDescription
WHEN NOT MATCHED THEN INSERT (RatingTypeId, RatingTypeName, RatingTypeDescription) VALUES (NEW_T.RatingTypeId, NEW_T.RatingTypeName, NEW_T.RatingTypeDescription)
OUTPUT $ACTION, inserted.RatingTypeId AS 'RatingTypeId' INTO @Output;
SELECT Action,
       RatingTypeId
FROM   @Output;