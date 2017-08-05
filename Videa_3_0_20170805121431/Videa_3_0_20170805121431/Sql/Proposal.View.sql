CREATE view [Proposal].[Proposal] as
    SELECT  CONVERT(char(32),'') AS ProposalHashKey,
    1 as ProposalSqn,
    CONVERT(datetime2,null) as StartDate,
    CONVERT(datetime2,null) as EndDate
GO

CREATE view [Proposal].[AvailList] as
    SELECT  CONVERT(char(32),'') AS AvailListHashKey,
    1 as AvailListSqn,
    CONVERT(char(32),'') AS ProposalHashKey,

    CONVERT(varchar(255),'') as Name,
    CONVERT(datetime2,null) as StartDate,
    CONVERT(datetime2,null) as EndDate

GO

CREATE view [Proposal].[AvailLineWithDetailedPeriods] as
    SELECT  CONVERT(char(32),'') AS AvailLineWithDetailedPeriodsHashKey,
    1 as AvailLineWithDetailedPeriodsSqn,
    CONVERT(char(32),'') AS AvailListHashKey,
    CONVERT(varchar(255),'') as DaypartName,
    CONVERT(varchar(255),'') as AvailName
GO
  

CREATE view [Proposal].[DetailedPeriod] as
    SELECT  CONVERT(char(32),'') AS DetailedPeriodHashKey,
    1 as DetailedPeriodSqn,
    CONVERT(char(32),'') AS AvailLineWithDetailedPeriodsHashKey,
    
    CONVERT(datetime2,null) as StartDate,
    CONVERT(datetime2,null) as EndDate,
    CONVERT(money,0) as Rate
GO
