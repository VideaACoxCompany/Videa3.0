CREATE PROCEDURE SellerRatingApi.RatingDemoAddUpdate
@RatingDemoHashKey CHAR (32), @RatingDemoSqn INT, @RatingDemoName VARCHAR (255)
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action            VARCHAR (20),
    RatingDemoHashKey CHAR (32)   );
MERGE INTO [SellerRating].[RatingDemo] WITH (HOLDLOCK)
 AS T
USING (SELECT @RatingDemoHashKey AS RatingDemoHashKey,
              @RatingDemoSqn AS RatingDemoSqn,
              @RatingDemoName AS RatingDemoName) AS NEW_T ON T.RatingDemoHashKey = NEW_T.RatingDemoHashKey
WHEN MATCHED THEN UPDATE 
SET T.RatingDemoSqn  = NEW_T.RatingDemoSqn,
    T.RatingDemoName = NEW_T.RatingDemoName
WHEN NOT MATCHED THEN INSERT (RatingDemoHashKey, RatingDemoSqn, RatingDemoName) VALUES (NEW_T.RatingDemoHashKey, NEW_T.RatingDemoSqn, NEW_T.RatingDemoName)
OUTPUT $ACTION, inserted.RatingDemoHashKey AS 'RatingDemoHashKey' INTO @Output;
SELECT Action,
       RatingDemoHashKey
FROM   @Output;