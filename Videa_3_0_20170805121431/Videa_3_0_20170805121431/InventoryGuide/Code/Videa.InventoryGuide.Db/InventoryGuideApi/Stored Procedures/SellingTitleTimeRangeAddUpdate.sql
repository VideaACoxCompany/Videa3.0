CREATE PROCEDURE InventoryGuideApi.SellingTitleTimeRangeAddUpdate
@SellingTitleTimeRangeHashKey CHAR (32), @TimeRangeSqn INT, @SellingTitleTimeRangeName VARCHAR (255)
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action                       VARCHAR (20),
    SellingTitleTimeRangeHashKey CHAR (32)   );
MERGE INTO [InventoryGuide].[SellingTitleTimeRange] WITH (HOLDLOCK)
 AS T
USING (SELECT @SellingTitleTimeRangeHashKey AS SellingTitleTimeRangeHashKey,
              @TimeRangeSqn AS TimeRangeSqn,
              @SellingTitleTimeRangeName AS SellingTitleTimeRangeName) AS NEW_T ON T.SellingTitleTimeRangeHashKey = NEW_T.SellingTitleTimeRangeHashKey
WHEN MATCHED THEN UPDATE 
SET T.TimeRangeSqn              = NEW_T.TimeRangeSqn,
    T.SellingTitleTimeRangeName = NEW_T.SellingTitleTimeRangeName
WHEN NOT MATCHED THEN INSERT (SellingTitleTimeRangeHashKey, TimeRangeSqn, SellingTitleTimeRangeName) VALUES (NEW_T.SellingTitleTimeRangeHashKey, NEW_T.TimeRangeSqn, NEW_T.SellingTitleTimeRangeName)
OUTPUT $ACTION, inserted.SellingTitleTimeRangeHashKey AS 'SellingTitleTimeRangeHashKey' INTO @Output;
SELECT Action,
       SellingTitleTimeRangeHashKey
FROM   @Output;