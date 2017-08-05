CREATE PROCEDURE [InventoryGuideApi].GetRateCardsByStation
@StationHashKey CHAR(32)
AS
WITH   cteRowNumber
AS(SELECT rc.RateCardHashKey,
               rc.RateCardName,
               rc.RateCardStartDate,
               rc.RateCardEndDate,
               row_number() OVER(PARTITION BY si.RateCardHashKey ORDER BY rc.RateCardSqn DESC) AS RowNum
        FROM   Inventory.RateCard AS rc
               INNER JOIN
               Inventory.SellableInventory AS si
               ON SI.RateCardHashKey = rc.RateCardHashKey
        WHERE  si.StationHashKey = @StationHashKey)
SELECT RateCardHashKey,
       RateCardName,
       RateCardStartDate,
       RateCardEndDate
FROM cteRowNumber
WHERE RowNum = 1;

            GO

            CREATE PROCEDURE [InventoryGuideApi].GetRateCardsByDateRange
@StartDate DateTime2, @EndDate DateTime2
AS
WITH   cteRowNumber
AS(SELECT rc.RateCardHashKey,
               rc.RateCardName,
               rc.RateCardStartDate,
               rc.RateCardEndDate,
               row_number() OVER(PARTITION BY si.RateCardHashKey ORDER BY rc.RateCardSqn DESC) AS RowNum
        FROM   Inventory.RateCard AS rc
               INNER JOIN
               Inventory.SellableInventory AS si
               ON SI.RateCardHashKey = rc.RateCardHashKey
        WHERE  rc.RateCardStartDate < @EndDate AND rc.RateCardEndDate >  @StartDate)
SELECT RateCardHashKey,
       RateCardName,
       RateCardStartDate,
       RateCardEndDate
FROM cteRowNumber
WHERE RowNum = 1;

            GO


            CREATE PROCEDURE [InventoryGuideApi].GetUnconfirmedInventory
            (
@StationHashKey CHAR(32), @RateCardTypeHashKey CHAR(32), @RateCardDaypartHashKey CHAR(32),
            @BroadcastWeekList ttBroadcastWeek READONLY
            )
AS
    SELECT si.SellableInventoryHashKey, st.SellingTitleName, st.SellingTitleStartDate, st.SellingTitleEndDate,
    d.RateCardDaypartName
    FROM[Inventory].[SellableInventory] si JOIN[Inventory].[SellingTitle]
        st
      ON st.SellingTitleHashKey = si.SellingTitleHashKey
JOIN[Inventory].[RateCardDaypart] d on d.RateCardDaypartHashKey = si.RateCardDaypartHashKey
 WHERE
        si.StationHashKey = @StationHashKey
        AND si.RateCardTypeHashKey = @RateCardTypeHashKey
        AND si.RateCardDaypartHashKey = @RateCardDaypartHashKey