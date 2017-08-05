CREATE PROCEDURE AMApi.DetailedPeriodAddUpdate
@DetailedPeriodHashKey CHAR (32), @DetailedPeriodSqn INT, @AvailLineWithDetailedPeriodsHashKey CHAR (32), @StartDate DATETIME2, @EndDate DATETIME2, @Rate MONEY
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action                VARCHAR (20),
    DetailedPeriodHashKey CHAR (32)   );
MERGE INTO [AM].[DetailedPeriod] WITH (HOLDLOCK)
 AS T
USING (SELECT @DetailedPeriodHashKey AS DetailedPeriodHashKey,
              @DetailedPeriodSqn AS DetailedPeriodSqn,
              @AvailLineWithDetailedPeriodsHashKey AS AvailLineWithDetailedPeriodsHashKey,
              @StartDate AS StartDate,
              @EndDate AS EndDate,
              @Rate AS Rate) AS NEW_T ON T.DetailedPeriodHashKey = NEW_T.DetailedPeriodHashKey
WHEN MATCHED THEN UPDATE 
SET T.AvailLineWithDetailedPeriodsHashKey = NEW_T.AvailLineWithDetailedPeriodsHashKey,
    T.StartDate                           = NEW_T.StartDate,
    T.EndDate                             = NEW_T.EndDate,
    T.Rate                                = NEW_T.Rate
WHEN NOT MATCHED THEN INSERT (DetailedPeriodHashKey, AvailLineWithDetailedPeriodsHashKey, StartDate, EndDate, Rate) VALUES (NEW_T.DetailedPeriodHashKey, NEW_T.AvailLineWithDetailedPeriodsHashKey, NEW_T.StartDate, NEW_T.EndDate, NEW_T.Rate)
OUTPUT $ACTION, inserted.DetailedPeriodHashKey AS 'DetailedPeriodHashKey' INTO @Output;
SELECT Action,
       DetailedPeriodHashKey
FROM   @Output;