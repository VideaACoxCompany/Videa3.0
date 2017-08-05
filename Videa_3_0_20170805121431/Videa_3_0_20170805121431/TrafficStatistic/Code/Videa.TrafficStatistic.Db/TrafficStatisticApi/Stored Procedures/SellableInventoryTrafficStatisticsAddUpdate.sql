CREATE PROCEDURE TrafficStatisticApi.SellableInventoryTrafficStatisticsAddUpdate
@SellableInventoryTrafficStatisticHashKey CHAR (32), @SellableInventoryHashKey CHAR (32), @SellableInventoryTrafficStatisticSqn INT, @SellableInventoryAURValue MONEY, @RowVersion TIMESTAMP=NULL
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action                                   VARCHAR (20),
    SellableInventoryTrafficStatisticHashKey CHAR (32)   ,
    RowVersion                               BINARY (8)  );
MERGE INTO [TrafficStatistic].[SellableInventoryTrafficStatistics] WITH (HOLDLOCK)
 AS T
USING (SELECT @SellableInventoryTrafficStatisticHashKey AS SellableInventoryTrafficStatisticHashKey,
              @SellableInventoryHashKey AS SellableInventoryHashKey,
              @SellableInventoryTrafficStatisticSqn AS SellableInventoryTrafficStatisticSqn,
              @SellableInventoryAURValue AS SellableInventoryAURValue,
              @RowVersion AS RowVersion) AS NEW_T ON T.SellableInventoryTrafficStatisticHashKey = NEW_T.SellableInventoryTrafficStatisticHashKey
WHEN MATCHED AND (NEW_T.RowVersion IS NULL
                  OR T.RowVersion = NEW_T.RowVersion) THEN UPDATE 
SET T.SellableInventoryHashKey  = NEW_T.SellableInventoryHashKey,
    T.SellableInventoryAURValue = NEW_T.SellableInventoryAURValue,
    T.ModifiedDateUtc           = GetUtcDate()
WHEN NOT MATCHED AND NEW_T.SellableInventoryTrafficStatisticHashKey = 0
                     AND NEW_T.RowVersion IS NULL THEN INSERT (SellableInventoryTrafficStatisticHashKey, SellableInventoryHashKey, SellableInventoryAURValue, CreatedDateUtc, ModifiedDateUtc) VALUES (NEW_T.SellableInventoryTrafficStatisticHashKey, NEW_T.SellableInventoryHashKey, NEW_T.SellableInventoryAURValue, GetUtcDate(), NULL)
OUTPUT $ACTION, inserted.SellableInventoryTrafficStatisticHashKey AS 'SellableInventoryTrafficStatisticHashKey', inserted.RowVersion AS 'RowVersion' INTO @Output;
SELECT Action,
       SellableInventoryTrafficStatisticHashKey,
       RowVersion
FROM   @Output;