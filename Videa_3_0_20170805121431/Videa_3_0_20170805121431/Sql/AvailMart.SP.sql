
CREATE PROCEDURE [AvailMartApi].GetAvailMart
(
@StationHashKey CHAR(32), @RateCardTypeHashKey CHAR(32), @DaypartHashKey CHAR(32),
@BroadcastWeekList ttBroadcastWeek READONLY
)
AS
    SELECT Convert(char(32), null) as  'AvailMartHashKey',

        1 as 'AvailMartSqn',
        Convert(datetime2, null ) as 'StartDate',
        Convert(datetime2, null ) as 'EndDate'


GO