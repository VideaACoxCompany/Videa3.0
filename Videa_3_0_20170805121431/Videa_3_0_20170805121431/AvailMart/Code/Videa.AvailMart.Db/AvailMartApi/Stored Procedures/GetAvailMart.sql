CREATE PROCEDURE AvailMartApi.GetAvailMart
@StationHashKey CHAR, @RateCardTypeHashKey CHAR, @DaypartHashKey CHAR, @BroadcastWeekList ttBroadcastWeek READONLY
AS
SELECT CONVERT (CHAR (32), NULL) AS 'AvailMartHashKey',
       1 AS 'AvailMartSqn',
       CONVERT (DATETIME2, NULL) AS 'StartDate',
       CONVERT (DATETIME2, NULL) AS 'EndDate';