CREATE PROCEDURE SIMApi.SellableInventoryAddUpdate
@SellableInventoryHashKey CHAR (32), @SellableInventorySqn INT, @StationHashKey CHAR (32), @StationGroupHashKey CHAR (32), @RateCardHashKey CHAR (32), @RateCardDaypartHashKey CHAR (32), @RateCardTypeHashKey CHAR (32), @SellingTitleHashKey CHAR (32), @SellingTitleDaysOfWeekHashKey CHAR (32), @SellingTitleTimeRangeHashKey CHAR (32), @SellableInventoryPeriodHashKey CHAR (32)
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action                   VARCHAR (20),
    SellableInventoryHashKey CHAR (32)   );
MERGE INTO [SIM].[SellableInventory] WITH (HOLDLOCK)
 AS T
USING (SELECT @SellableInventoryHashKey AS SellableInventoryHashKey,
              @SellableInventorySqn AS SellableInventorySqn,
              @StationHashKey AS StationHashKey,
              @StationGroupHashKey AS StationGroupHashKey,
              @RateCardHashKey AS RateCardHashKey,
              @RateCardDaypartHashKey AS RateCardDaypartHashKey,
              @RateCardTypeHashKey AS RateCardTypeHashKey,
              @SellingTitleHashKey AS SellingTitleHashKey,
              @SellingTitleDaysOfWeekHashKey AS SellingTitleDaysOfWeekHashKey,
              @SellingTitleTimeRangeHashKey AS SellingTitleTimeRangeHashKey,
              @SellableInventoryPeriodHashKey AS SellableInventoryPeriodHashKey) AS NEW_T ON T.SellableInventoryHashKey = NEW_T.SellableInventoryHashKey
WHEN MATCHED THEN UPDATE 
SET T.StationHashKey                 = NEW_T.StationHashKey,
    T.StationGroupHashKey            = NEW_T.StationGroupHashKey,
    T.RateCardHashKey                = NEW_T.RateCardHashKey,
    T.RateCardDaypartHashKey         = NEW_T.RateCardDaypartHashKey,
    T.RateCardTypeHashKey            = NEW_T.RateCardTypeHashKey,
    T.SellingTitleHashKey            = NEW_T.SellingTitleHashKey,
    T.SellingTitleDaysOfWeekHashKey  = NEW_T.SellingTitleDaysOfWeekHashKey,
    T.SellingTitleTimeRangeHashKey   = NEW_T.SellingTitleTimeRangeHashKey,
    T.SellableInventoryPeriodHashKey = NEW_T.SellableInventoryPeriodHashKey,
    T.ModifiedDateUtc                = GetUtcDate()
WHEN NOT MATCHED THEN INSERT (SellableInventoryHashKey, StationHashKey, StationGroupHashKey, RateCardHashKey, RateCardDaypartHashKey, RateCardTypeHashKey, SellingTitleHashKey, SellingTitleDaysOfWeekHashKey, SellingTitleTimeRangeHashKey, SellableInventoryPeriodHashKey, CreatedDateUtc, ModifiedDateUtc) VALUES (NEW_T.SellableInventoryHashKey, NEW_T.StationHashKey, NEW_T.StationGroupHashKey, NEW_T.RateCardHashKey, NEW_T.RateCardDaypartHashKey, NEW_T.RateCardTypeHashKey, NEW_T.SellingTitleHashKey, NEW_T.SellingTitleDaysOfWeekHashKey, NEW_T.SellingTitleTimeRangeHashKey, NEW_T.SellableInventoryPeriodHashKey, GetUtcDate(), NULL)
OUTPUT $ACTION, inserted.SellableInventoryHashKey AS 'SellableInventoryHashKey' INTO @Output;
SELECT Action,
       SellableInventoryHashKey
FROM   @Output;