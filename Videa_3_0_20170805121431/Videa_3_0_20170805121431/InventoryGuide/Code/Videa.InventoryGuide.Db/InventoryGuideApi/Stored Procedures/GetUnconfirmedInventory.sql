CREATE PROCEDURE InventoryGuideApi.GetUnconfirmedInventory
@StationHashKey CHAR, @RateCardTypeHashKey CHAR, @RateCardDaypartHashKey CHAR, @BroadcastWeekList ttBroadcastWeek READONLY
AS
SELECT si.SellableInventoryHashKey,
       st.SellingTitleName,
       st.SellingTitleStartDate,
       st.SellingTitleEndDate,
       d.RateCardDaypartName
FROM   [Inventory].[SellableInventory] AS si
       INNER JOIN
       [Inventory].[SellingTitle] AS st
       ON st.SellingTitleHashKey = si.SellingTitleHashKey
       INNER JOIN
       [Inventory].[RateCardDaypart] AS d
       ON d.RateCardDaypartHashKey = si.RateCardDaypartHashKey
WHERE  si.StationHashKey = @StationHashKey
       AND si.RateCardTypeHashKey = @RateCardTypeHashKey
       AND si.RateCardDaypartHashKey = @RateCardDaypartHashKey;