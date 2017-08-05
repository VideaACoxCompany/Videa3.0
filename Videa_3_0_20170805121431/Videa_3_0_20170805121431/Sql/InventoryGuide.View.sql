CREATE view [InventoryMart].[SellingTitle] as
            SELECT  CONVERT(char(32),'') AS SellingTitleHashKey,
            1 as SellingTitleSqn,
            CONVERT(varchar(255),'') as SellingTitleName,
            CONVERT(datetime2,null) as SellingTitleStartDate,
            CONVERT(datetime2,null) as SellingTitleEndDate
        GO

        CREATE view [InventoryMart].[Station] as
            SELECT  CONVERT(char(32),'') AS StationHashKey,
            1 as StationSqn,
            CONVERT(varchar(255),'') as StationName,
            CONVERT(varchar(10),'') as StationCallLetters

        GO

        CREATE view [InventoryMart].[StationGroup] as
            SELECT  CONVERT(char(32),'') AS StationGroupHashKey,
            1 as StationGroupSqn,
            CONVERT(varchar(255),'') as StationGroupName

        GO

        CREATE view [InventoryMart].[RateCard] as
            SELECT  CONVERT(char(32),'') AS RateCardHashKey,
            1 as RateCardSqn,
            CONVERT(varchar(255),'') as RateCardName,
            CONVERT(datetime2,null) as RateCardStartDate,
            CONVERT(datetime2,null) as RateCardEndDate

        GO

        CREATE view [InventoryMart].[RateCardDaypart] as
            SELECT  CONVERT(char(32),'') AS RateCardDaypartHashKey,
            1 as RateCardDaypartSqn,
            CONVERT(varchar(255),'') as RateCardDaypartName

        GO

        CREATE view [InventoryMart].[RateCardType] as
            SELECT  CONVERT(char(32),'') AS RateCardTypeHashKey,
            1 as RateCardTypeSqn,
            CONVERT(varchar(255),'') as RateCardTypeName

        GO

        CREATE view [InventoryMart].[SellingTitleTimeRange] as
            SELECT  CONVERT(char(32),'') AS SellingTitleTimeRangeHashKey,
            1 as TimeRangeSqn,
            CONVERT(varchar(255),'') as SellingTitleTimeRangeName

        GO

        CREATE view [InventoryMart].[SellingTitleDaysOfWeek] as
            SELECT  CONVERT(char(32),'') AS SellingTitleDaysOfWeekHashKey,
            1 as SellingTitleDaysOfWeekSqn,
            CONVERT(varchar(255),'') as SellingTitleDaysOfWeekName,
            CONVERT(bit,null) as Mon,
            CONVERT(bit,null) as Tue,
            CONVERT(bit,null) as Wed,
            CONVERT(bit,null) as Thu,
            CONVERT(bit,null) as Fri,
            CONVERT(bit,null) as Sat,
            CONVERT(bit,null) as Sun

        GO

        CREATE view [InventoryMart].[RatePeriod] as
            SELECT  CONVERT(char(32),'') AS RatePeriodHashKey,
            1 as RatePeriodSqn,
            CONVERT(varchar(255),'') as RatePeriodName,
            CONVERT(datetime2,null) as RatePeriodStartDate,
            CONVERT(datetime2,null) as RatePeriodEndDate

        GO

        CREATE view [InventoryMart].[SellableInventory] as
            SELECT  CONVERT(char(32),'') AS SellableInventoryHashKey,
            1 as SellableInventorySqn,
            CONVERT(char(32),'') AS StationHashKey,
            CONVERT(char(32),'') AS StationGroupHashKey,
            CONVERT(char(32),'') AS RateCardHashKey,
            CONVERT(char(32),'') AS RateCardDaypartHashKey,
            CONVERT(char(32),'') AS RateCardTypeHashKey,
            CONVERT(char(32),'') AS SellingTitleHashKey,
            CONVERT(char(32),'') AS SellingTitleDaysOfWeekHashKey,
            CONVERT(char(32),'') AS SellingTitleTimeRangeHashKey,
            CONVERT(char(32),'') AS RatePeriodHashKey,
   
   
        --    convert(ROWVERSION, null) as RowVersion,
            convert(DateTime2, null) as CreatedDateUtc,
            convert(DateTime2, null) as ModifiedDateUtc

        GO