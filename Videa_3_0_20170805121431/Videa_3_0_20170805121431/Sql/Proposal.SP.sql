
CREATE PROCEDURE [ProposalApi].GetProposal
(
@StationHashKey CHAR(32), @RateCardTypeHashKey CHAR(32), @DaypartHashKey CHAR(32),
@BroadcastWeekList ttBroadcastWeek READONLY
)
AS
    SELECT Convert(char(32), null) as  'ProposalHashKey',

        1 as 'ProposalSqn',
        Convert(datetime2, null ) as 'StartDate',
        Convert(datetime2, null ) as 'EndDate'


GO