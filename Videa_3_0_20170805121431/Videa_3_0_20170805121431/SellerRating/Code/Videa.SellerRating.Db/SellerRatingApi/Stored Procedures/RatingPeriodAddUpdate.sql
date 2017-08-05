CREATE PROCEDURE SellerRatingApi.RatingPeriodAddUpdate
@RatingPeriodHashKey CHAR (32), @RatingPeriodSqn INT, @RatingPeriodName VARCHAR (255), @RatingPeriodStartDate DATETIME2, @RatingPeriodEndDate DATETIME2
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action              VARCHAR (20),
    RatingPeriodHashKey CHAR (32)   );
MERGE INTO [SellerRating].[RatingPeriod] WITH (HOLDLOCK)
 AS T
USING (SELECT @RatingPeriodHashKey AS RatingPeriodHashKey,
              @RatingPeriodSqn AS RatingPeriodSqn,
              @RatingPeriodName AS RatingPeriodName,
              @RatingPeriodStartDate AS RatingPeriodStartDate,
              @RatingPeriodEndDate AS RatingPeriodEndDate) AS NEW_T ON T.RatingPeriodHashKey = NEW_T.RatingPeriodHashKey
WHEN MATCHED THEN UPDATE 
SET T.RatingPeriodSqn       = NEW_T.RatingPeriodSqn,
    T.RatingPeriodName      = NEW_T.RatingPeriodName,
    T.RatingPeriodStartDate = NEW_T.RatingPeriodStartDate,
    T.RatingPeriodEndDate   = NEW_T.RatingPeriodEndDate
WHEN NOT MATCHED THEN INSERT (RatingPeriodHashKey, RatingPeriodSqn, RatingPeriodName, RatingPeriodStartDate, RatingPeriodEndDate) VALUES (NEW_T.RatingPeriodHashKey, NEW_T.RatingPeriodSqn, NEW_T.RatingPeriodName, NEW_T.RatingPeriodStartDate, NEW_T.RatingPeriodEndDate)
OUTPUT $ACTION, inserted.RatingPeriodHashKey AS 'RatingPeriodHashKey' INTO @Output;
SELECT Action,
       RatingPeriodHashKey
FROM   @Output;