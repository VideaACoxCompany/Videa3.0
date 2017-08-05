CREATE PROCEDURE SIMApi.StationAddUpdate
@StationHashKey CHAR (32), @StationSqn INT, @StationName VARCHAR (255), @StationCallLetters VARCHAR (10)
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action         VARCHAR (20),
    StationHashKey CHAR (32)   );
MERGE INTO [SIM].[Station] WITH (HOLDLOCK)
 AS T
USING (SELECT @StationHashKey AS StationHashKey,
              @StationSqn AS StationSqn,
              @StationName AS StationName,
              @StationCallLetters AS StationCallLetters) AS NEW_T ON T.StationHashKey = NEW_T.StationHashKey
WHEN MATCHED THEN UPDATE 
SET T.StationName        = NEW_T.StationName,
    T.StationCallLetters = NEW_T.StationCallLetters
WHEN NOT MATCHED THEN INSERT (StationHashKey, StationName, StationCallLetters) VALUES (NEW_T.StationHashKey, NEW_T.StationName, NEW_T.StationCallLetters)
OUTPUT $ACTION, inserted.StationHashKey AS 'StationHashKey' INTO @Output;
SELECT Action,
       StationHashKey
FROM   @Output;