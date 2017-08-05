CREATE PROCEDURE AMApi.AvailMartAddUpdate
@AvailMartHashKey CHAR (32), @AvailMartSqn INT, @StartDate DATETIME2, @EndDate DATETIME2
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action           VARCHAR (20),
    AvailMartHashKey CHAR (32)   );
MERGE INTO [AM].[AvailMart] WITH (HOLDLOCK)
 AS T
USING (SELECT @AvailMartHashKey AS AvailMartHashKey,
              @AvailMartSqn AS AvailMartSqn,
              @StartDate AS StartDate,
              @EndDate AS EndDate) AS NEW_T ON T.AvailMartHashKey = NEW_T.AvailMartHashKey
WHEN MATCHED THEN UPDATE 
SET T.StartDate = NEW_T.StartDate,
    T.EndDate   = NEW_T.EndDate
WHEN NOT MATCHED THEN INSERT (AvailMartHashKey, StartDate, EndDate) VALUES (NEW_T.AvailMartHashKey, NEW_T.StartDate, NEW_T.EndDate)
OUTPUT $ACTION, inserted.AvailMartHashKey AS 'AvailMartHashKey' INTO @Output;
SELECT Action,
       AvailMartHashKey
FROM   @Output;