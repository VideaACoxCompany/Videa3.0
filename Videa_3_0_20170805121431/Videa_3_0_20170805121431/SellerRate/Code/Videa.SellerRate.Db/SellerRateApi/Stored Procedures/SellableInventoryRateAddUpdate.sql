CREATE PROCEDURE SellerRateApi.SellableInventoryRateAddUpdate
@SellableInventoryRateHashKey CHAR (32), @SellableInventoryHashKey CHAR (32), @SellableInventoryRateSqn INT, @RateTierHashKey CHAR (32), @RatePeriodHashKey CHAR (32), @SellableInventoryRateValue MONEY, @RowVersion TIMESTAMP=NULL
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action                       VARCHAR (20),
    SellableInventoryRateHashKey CHAR (32)   ,
    RowVersion                   BINARY (8)  );
MERGE INTO [SellerRate].[SellableInventoryRate] WITH (HOLDLOCK)
 AS T
USING (SELECT @SellableInventoryRateHashKey AS SellableInventoryRateHashKey,
              @SellableInventoryHashKey AS SellableInventoryHashKey,
              @SellableInventoryRateSqn AS SellableInventoryRateSqn,
              @RateTierHashKey AS RateTierHashKey,
              @RatePeriodHashKey AS RatePeriodHashKey,
              @SellableInventoryRateValue AS SellableInventoryRateValue,
              @RowVersion AS RowVersion) AS NEW_T ON T.SellableInventoryRateHashKey = NEW_T.SellableInventoryRateHashKey
WHEN MATCHED AND (NEW_T.RowVersion IS NULL
                  OR T.RowVersion = NEW_T.RowVersion) THEN UPDATE 
SET T.SellableInventoryHashKey   = NEW_T.SellableInventoryHashKey,
    T.RateTierHashKey            = NEW_T.RateTierHashKey,
    T.RatePeriodHashKey          = NEW_T.RatePeriodHashKey,
    T.SellableInventoryRateValue = NEW_T.SellableInventoryRateValue,
    T.ModifiedDateUtc            = GetUtcDate()
WHEN NOT MATCHED AND NEW_T.SellableInventoryRateHashKey = 0
                     AND NEW_T.RowVersion IS NULL THEN INSERT (SellableInventoryRateHashKey, SellableInventoryHashKey, RateTierHashKey, RatePeriodHashKey, SellableInventoryRateValue, CreatedDateUtc, ModifiedDateUtc) VALUES (NEW_T.SellableInventoryRateHashKey, NEW_T.SellableInventoryHashKey, NEW_T.RateTierHashKey, NEW_T.RatePeriodHashKey, NEW_T.SellableInventoryRateValue, GetUtcDate(), NULL)
OUTPUT $ACTION, inserted.SellableInventoryRateHashKey AS 'SellableInventoryRateHashKey', inserted.RowVersion AS 'RowVersion' INTO @Output;
SELECT Action,
       SellableInventoryRateHashKey,
       RowVersion
FROM   @Output;