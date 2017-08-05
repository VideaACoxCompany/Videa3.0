 
CREATE view [TrafficStatistic].[RatePeriod] as
    SELECT  CONVERT(char(32),'') AS RatePeriodHashKey,
    1 as RatePeriodSqn,
    CONVERT(varchar(255),'') as RatePeriodName,
    CONVERT(datetime2,null) as RatePeriodStartDate,
    CONVERT(datetime2,null) as RatePeriodEndDate

GO

    
 CREATE view [TrafficStatistic].[SellableInventoryTrafficStatistics] as
 SELECT  CONVERT(char(32),'') AS SellableInventoryTrafficStatisticHashKey,
      CONVERT(char(32),'') AS SellableInventoryHashKey,
        1 as SellableInventoryTrafficStatisticSqn,
        
        convert(money,0) as SellableInventoryAURValue,
        convert(ROWVERSION, null) as RowVersion,
        convert(DateTime2, null) as CreatedDateUtc,
        convert(DateTime2, null) as ModifiedDateUtc

    GO