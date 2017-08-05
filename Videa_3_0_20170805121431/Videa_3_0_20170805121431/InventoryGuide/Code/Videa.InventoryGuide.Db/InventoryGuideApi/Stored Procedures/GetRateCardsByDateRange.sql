CREATE PROCEDURE InventoryGuideApi.GetRateCardsByDateRange
@StartDate DATETIME2, @EndDate DATETIME2
AS
WITH   cteRowNumber
AS     (SELECT rc.RateCardHashKey,
               rc.RateCardName,
               rc.RateCardStartDate,
               rc.RateCardEndDate,
               row_number() OVER (PARTITION BY si.RateCardHashKey ORDER BY rc.RateCardSqn DESC) AS RowNum
        FROM   Inventory.RateCard AS rc
               INNER JOIN
               Inventory.SellableInventory AS si
               ON SI.RateCardHashKey = rc.RateCardHashKey
        WHERE  rc.RateCardStartDate < @EndDate
               AND rc.RateCardEndDate > @StartDate)
SELECT RateCardHashKey,
       RateCardName,
       RateCardStartDate,
       RateCardEndDate
FROM   cteRowNumber
WHERE  RowNum = 1;