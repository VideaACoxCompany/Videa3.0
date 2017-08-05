CREATE PROCEDURE SIMApi.SellableInventoryPeriodAddUpdate
@SellableInventoryPeriodHashKey CHAR (32), @SellableInventoryPeriodSqn INT, @SellableInventoryPeriodName VARCHAR (255), @SellableInventoryPeriodStartDate DATETIME2, @SellableInventoryPeriodEndDate DATETIME2
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action                         VARCHAR (20),
    SellableInventoryPeriodHashKey CHAR (32)   );
MERGE INTO [SIM].[SellableInventoryPeriod] WITH (HOLDLOCK)
 AS T
USING (SELECT @SellableInventoryPeriodHashKey AS SellableInventoryPeriodHashKey,
              @SellableInventoryPeriodSqn AS SellableInventoryPeriodSqn,
              @SellableInventoryPeriodName AS SellableInventoryPeriodName,
              @SellableInventoryPeriodStartDate AS SellableInventoryPeriodStartDate,
              @SellableInventoryPeriodEndDate AS SellableInventoryPeriodEndDate) AS NEW_T ON T.SellableInventoryPeriodHashKey = NEW_T.SellableInventoryPeriodHashKey
WHEN MATCHED THEN UPDATE 
SET T.SellableInventoryPeriodName      = NEW_T.SellableInventoryPeriodName,
    T.SellableInventoryPeriodStartDate = NEW_T.SellableInventoryPeriodStartDate,
    T.SellableInventoryPeriodEndDate   = NEW_T.SellableInventoryPeriodEndDate
WHEN NOT MATCHED THEN INSERT (SellableInventoryPeriodHashKey, SellableInventoryPeriodName, SellableInventoryPeriodStartDate, SellableInventoryPeriodEndDate) VALUES (NEW_T.SellableInventoryPeriodHashKey, NEW_T.SellableInventoryPeriodName, NEW_T.SellableInventoryPeriodStartDate, NEW_T.SellableInventoryPeriodEndDate)
OUTPUT $ACTION, inserted.SellableInventoryPeriodHashKey AS 'SellableInventoryPeriodHashKey' INTO @Output;
SELECT Action,
       SellableInventoryPeriodHashKey
FROM   @Output;