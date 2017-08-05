CREATE PROCEDURE AMApi.AvailLineWithDetailedPeriodsAddUpdate
@AvailLineWithDetailedPeriodsHashKey CHAR (32), @AvailLineWithDetailedPeriodsSqn INT, @AvailListHashKey CHAR (32), @DaypartName VARCHAR (255), @AvailName VARCHAR (255)
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action                              VARCHAR (20),
    AvailLineWithDetailedPeriodsHashKey CHAR (32)   );
MERGE INTO [AM].[AvailLineWithDetailedPeriods] WITH (HOLDLOCK)
 AS T
USING (SELECT @AvailLineWithDetailedPeriodsHashKey AS AvailLineWithDetailedPeriodsHashKey,
              @AvailLineWithDetailedPeriodsSqn AS AvailLineWithDetailedPeriodsSqn,
              @AvailListHashKey AS AvailListHashKey,
              @DaypartName AS DaypartName,
              @AvailName AS AvailName) AS NEW_T ON T.AvailLineWithDetailedPeriodsHashKey = NEW_T.AvailLineWithDetailedPeriodsHashKey
WHEN MATCHED THEN UPDATE 
SET T.AvailListHashKey = NEW_T.AvailListHashKey,
    T.DaypartName      = NEW_T.DaypartName,
    T.AvailName        = NEW_T.AvailName
WHEN NOT MATCHED THEN INSERT (AvailLineWithDetailedPeriodsHashKey, AvailListHashKey, DaypartName, AvailName) VALUES (NEW_T.AvailLineWithDetailedPeriodsHashKey, NEW_T.AvailListHashKey, NEW_T.DaypartName, NEW_T.AvailName)
OUTPUT $ACTION, inserted.AvailLineWithDetailedPeriodsHashKey AS 'AvailLineWithDetailedPeriodsHashKey' INTO @Output;
SELECT Action,
       AvailLineWithDetailedPeriodsHashKey
FROM   @Output;