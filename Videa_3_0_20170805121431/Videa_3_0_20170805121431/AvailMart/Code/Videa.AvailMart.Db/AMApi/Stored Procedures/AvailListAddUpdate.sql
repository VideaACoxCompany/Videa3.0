CREATE PROCEDURE AMApi.AvailListAddUpdate
@AvailListHashKey CHAR (32), @AvailListSqn INT, @AvailMartHashKey CHAR (32), @Name VARCHAR (255), @StartDate DATETIME2, @EndDate DATETIME2
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action           VARCHAR (20),
    AvailListHashKey CHAR (32)   );
MERGE INTO [AM].[AvailList] WITH (HOLDLOCK)
 AS T
USING (SELECT @AvailListHashKey AS AvailListHashKey,
              @AvailListSqn AS AvailListSqn,
              @AvailMartHashKey AS AvailMartHashKey,
              @Name AS Name,
              @StartDate AS StartDate,
              @EndDate AS EndDate) AS NEW_T ON T.AvailListHashKey = NEW_T.AvailListHashKey
WHEN MATCHED THEN UPDATE 
SET T.AvailMartHashKey = NEW_T.AvailMartHashKey,
    T.Name             = NEW_T.Name,
    T.StartDate        = NEW_T.StartDate,
    T.EndDate          = NEW_T.EndDate
WHEN NOT MATCHED THEN INSERT (AvailListHashKey, AvailMartHashKey, Name, StartDate, EndDate) VALUES (NEW_T.AvailListHashKey, NEW_T.AvailMartHashKey, NEW_T.Name, NEW_T.StartDate, NEW_T.EndDate)
OUTPUT $ACTION, inserted.AvailListHashKey AS 'AvailListHashKey' INTO @Output;
SELECT Action,
       AvailListHashKey
FROM   @Output;