CREATE PROCEDURE TrafficStatisticApi.RatePeriodAddUpdate
@RatePeriodHashKey CHAR (32), @RatePeriodSqn INT, @RatePeriodName VARCHAR (255), @RatePeriodStartDate DATETIME2, @RatePeriodEndDate DATETIME2
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action            VARCHAR (20),
    RatePeriodHashKey CHAR (32)   );
MERGE INTO [TrafficStatistic].[RatePeriod] WITH (HOLDLOCK)
 AS T
USING (SELECT @RatePeriodHashKey AS RatePeriodHashKey,
              @RatePeriodSqn AS RatePeriodSqn,
              @RatePeriodName AS RatePeriodName,
              @RatePeriodStartDate AS RatePeriodStartDate,
              @RatePeriodEndDate AS RatePeriodEndDate) AS NEW_T ON T.RatePeriodHashKey = NEW_T.RatePeriodHashKey
WHEN MATCHED THEN UPDATE 
SET T.RatePeriodName      = NEW_T.RatePeriodName,
    T.RatePeriodStartDate = NEW_T.RatePeriodStartDate,
    T.RatePeriodEndDate   = NEW_T.RatePeriodEndDate
WHEN NOT MATCHED THEN INSERT (RatePeriodHashKey, RatePeriodName, RatePeriodStartDate, RatePeriodEndDate) VALUES (NEW_T.RatePeriodHashKey, NEW_T.RatePeriodName, NEW_T.RatePeriodStartDate, NEW_T.RatePeriodEndDate)
OUTPUT $ACTION, inserted.RatePeriodHashKey AS 'RatePeriodHashKey' INTO @Output;
SELECT Action,
       RatePeriodHashKey
FROM   @Output;