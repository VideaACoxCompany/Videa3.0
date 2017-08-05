CREATE PROCEDURE InventoryGuideApi.StationGroupAddUpdate
@StationGroupHashKey CHAR (32), @StationGroupSqn INT, @StationGroupName VARCHAR (255)
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action              VARCHAR (20),
    StationGroupHashKey CHAR (32)   );
MERGE INTO [InventoryGuide].[StationGroup] WITH (HOLDLOCK)
 AS T
USING (SELECT @StationGroupHashKey AS StationGroupHashKey,
              @StationGroupSqn AS StationGroupSqn,
              @StationGroupName AS StationGroupName) AS NEW_T ON T.StationGroupHashKey = NEW_T.StationGroupHashKey
WHEN MATCHED THEN UPDATE 
SET T.StationGroupName = NEW_T.StationGroupName
WHEN NOT MATCHED THEN INSERT (StationGroupHashKey, StationGroupName) VALUES (NEW_T.StationGroupHashKey, NEW_T.StationGroupName)
OUTPUT $ACTION, inserted.StationGroupHashKey AS 'StationGroupHashKey' INTO @Output;
SELECT Action,
       StationGroupHashKey
FROM   @Output;