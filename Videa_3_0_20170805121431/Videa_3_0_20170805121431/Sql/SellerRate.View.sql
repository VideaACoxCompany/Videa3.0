
CREATE view [SellerRate].[RateTier] as
    SELECT  CONVERT(char(32),'') AS RateTierHashKey,
    1 as RateTierSqn,
    CONVERT(varchar(255),'') as RateTierName

GO

CREATE view [SellerRate].[RatePeriod] as
    SELECT  CONVERT(char(32),'') AS RatePeriodHashKey,
    1 as RatePeriodSqn,
    CONVERT(varchar(255),'') as RatePeriodName,
    CONVERT(datetime2,null) as RatePeriodStartDate,
    CONVERT(datetime2,null) as RatePeriodEndDate

GO

    
 CREATE view [SellerRate].[SellableInventoryRate] as
 SELECT  CONVERT(char(32),'') AS SellableInventoryRateHashKey,
      CONVERT(char(32),'') AS SellableInventoryHashKey,
        1 as SellableInventoryRateSqn,
        CONVERT(char(32),'') AS RateTierHashKey,
		CONVERT(char(32),'') AS RatePeriodHashKey,
        convert(money,0) as SellableInventoryRateValue,
        convert(ROWVERSION, null) as RowVersion,
        convert(DateTime2, null) as CreatedDateUtc,
        convert(DateTime2, null) as ModifiedDateUtc

    GO