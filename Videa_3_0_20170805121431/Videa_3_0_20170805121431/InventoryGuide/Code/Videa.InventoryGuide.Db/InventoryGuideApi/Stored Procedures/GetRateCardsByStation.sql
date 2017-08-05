CREATE PROCEDURE InventoryGuideApi.GetRateCardsByStation
@StationHashKey CHAR
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
        WHERE  si.StationHashKey = @StationHashKey)
SELECT RateCardHashKey,
       RateCardName,
       RateCardStartDate,
       RateCardEndDate
FROM   cteRowNumber
WHERE  RowNum = 1;