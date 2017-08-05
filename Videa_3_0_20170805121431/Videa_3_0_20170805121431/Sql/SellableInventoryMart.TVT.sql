CREATE TYPE [SIMApi].[ttBroadcastWeek] AS 
TABLE(  [BroadcastWeekHashKey] char(32) NOT NULL)

CREATE TYPE [SIMApi].[ttRateCardDaypart] AS 
TABLE(  [RateCardDaypartHashKey] char(32) NOT NULL)

CREATE TYPE [SIMApi].[ttSellingTitle] AS 
TABLE(  [SellingTitleHashKey] char(32) NOT NULL)


CREATE TYPE [SIMApi].[ttStation] AS 
TABLE(  [StationHashKey] char(32) NOT NULL)