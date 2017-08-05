CREATE view [AvailMart].[AvailMart] as
    SELECT  CONVERT(char(32),'') AS AvailMartHashKey,
    1 as AvailMartSqn,
    CONVERT(datetime2,null) as StartDate,
    CONVERT(datetime2,null) as EndDate
GO

CREATE view [AvailMart].[AvailList] as
    SELECT  CONVERT(char(32),'') AS AvailListHashKey,
    1 as AvailListSqn,
    CONVERT(char(32),'') AS AvailMartHashKey,

    CONVERT(varchar(255),'') as Name,
    CONVERT(datetime2,null) as StartDate,
    CONVERT(datetime2,null) as EndDate

GO

CREATE view [AvailMart].[AvailLineWithDetailedPeriods] as
    SELECT  CONVERT(char(32),'') AS AvailLineWithDetailedPeriodsHashKey,
    1 as AvailLineWithDetailedPeriodsSqn,
    CONVERT(char(32),'') AS AvailListHashKey,
    CONVERT(varchar(255),'') as DaypartName,
    CONVERT(varchar(255),'') as AvailName
GO
  

CREATE view [AvailMart].[DetailedPeriod] as
    SELECT  CONVERT(char(32),'') AS DetailedPeriodHashKey,
    1 as DetailedPeriodSqn,
    CONVERT(char(32),'') AS AvailLineWithDetailedPeriodsHashKey,
    
    CONVERT(datetime2,null) as StartDate,
    CONVERT(datetime2,null) as EndDate,
    CONVERT(money,0) as Rate
GO
