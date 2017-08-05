CREATE PROCEDURE [SIMApi].GetRateCardsByStation
 (@StationHashKey CHAR(32) )
AS
BEGIN
WITH   cteRowNumber
AS(SELECT rc.RateCardHashKey,
               rc.RateCardName,
               rc.RateCardStartDate,
               rc.RateCardEndDate,
               row_number() OVER(PARTITION BY si.RateCardHashKey ORDER BY rc.RateCardSqn DESC) AS RowNum
        FROM   [SIM].RateCard AS rc
               INNER JOIN
               [SIM].SellableInventory AS si
               ON SI.RateCardHashKey = rc.RateCardHashKey
        WHERE  si.StationHashKey = @StationHashKey)
SELECT RateCardHashKey,
       RateCardName,
       RateCardStartDate,
       RateCardEndDate
FROM cteRowNumber
WHERE RowNum = 1
END

GO


CREATE PROCEDURE [SIMApi].GetRateCardsByDateRange
@StartDate DateTime2, @EndDate DateTime2
AS
WITH   cteRowNumber
AS(SELECT rc.RateCardHashKey,
               rc.RateCardName,
               rc.RateCardStartDate,
               rc.RateCardEndDate,
               row_number() OVER(PARTITION BY si.RateCardHashKey ORDER BY rc.RateCardSqn DESC) AS RowNum
        FROM   [SIM].RateCard AS rc
               INNER JOIN
               [SIM].SellableInventory AS si
               ON SI.RateCardHashKey = rc.RateCardHashKey
        WHERE  rc.RateCardStartDate < @EndDate AND rc.RateCardEndDate >  @StartDate)
SELECT RateCardHashKey,
       RateCardName,
       RateCardStartDate,
       RateCardEndDate
FROM cteRowNumber
WHERE RowNum = 1;
GO

CREATE PROCEDURE [SIMApi].GetConfirmedInventory
@StationList [ttStation] READONLY, @RateCardTypeHashKey CHAR (32), @RateCardDaypartList [ttRateCardDaypart] READONLY, @SellingTitleList [ttSellingTitle] READONLY, @BroadcastWeekList ttBroadcastWeek READONLY
AS
SELECT si.SellableInventoryHashKey,
       st.SellingTitleName,
       st.SellingTitleStartDate,
       st.SellingTitleEndDate,
       d.RateCardDaypartName,
       CONVERT (CHAR (32), '') AS StationHashKey,
       CONVERT (CHAR (32), '') AS SellingTitleDaysOfWeekHashKey,
       CONVERT (VARCHAR (255), '') AS SellingTitleDaysOfWeekName,
       CONVERT (CHAR (32), '') AS RateCardTypeHashKey,
       CONVERT (VARCHAR (255), '') AS RateCardTypeName
FROM   [SIM].[SellableInventory] AS si
       INNER JOIN
       [SIM].[SellingTitle] AS st
       ON st.SellingTitleHashKey = si.SellingTitleHashKey
       INNER JOIN
       [SIM].[RateCardDaypart] AS d
       ON d.RateCardDaypartHashKey = si.RateCardDaypartHashKey
       INNER JOIN
       @RateCardDaypartList AS dl
       ON dl.RateCardDaypartHashKey = si.RateCardDaypartHashKey
       INNER JOIN
       @SellingTitleList AS stl
       ON stl.SellingTitleHashKey = si.SellingTitleHashKey
WHERE  si.StationHashKey IN (SELECT [StationHashKey]
                             FROM   @StationList)
       AND si.RateCardTypeHashKey = @RateCardTypeHashKey;
