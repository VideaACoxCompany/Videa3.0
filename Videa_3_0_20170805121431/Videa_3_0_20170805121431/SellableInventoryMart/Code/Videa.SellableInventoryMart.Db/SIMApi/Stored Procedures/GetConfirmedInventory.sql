CREATE PROCEDURE SIMApi.GetConfirmedInventory
@StationList ttStation READONLY, @RateCardTypeHashKey CHAR, @RateCardDaypartList ttRateCardDaypart READONLY, @SellingTitleList ttSellingTitle READONLY, @BroadcastWeekList ttBroadcastWeek READONLY
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