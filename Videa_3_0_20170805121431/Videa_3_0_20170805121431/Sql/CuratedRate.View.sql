CREATE view [SIR].[CuratedRate] as 
            select 
            convert(bigint,1) as CuratedRateId,
            convert(char(32),'') as SellableInventoryHashKey, 
            convert(char(32),'') as RateHashKey, 
            convert(int, 1 ) as RateVersion,
			convert(money,0) as CuratedRateValue,
            convert(bit,1) as IsDynamicRate, --todo: create lookup table
            convert(int, 1) as RateTypeId, 
            convert(int, 1) as CurationStatusId,
            convert(datetime2,getdate()) as CreatedDateUtc,
            convert(varchar(255),'user name') as CreatedBy,
            convert(datetime2,getdate()) as ModifiedDateUtc,
            convert(varchar(255),'user name who change') as ModifiedBy,
            convert(RowVersion,null) as RowVersion

            GO
                
            CREATE view [SIR].[RateType] as
            select 1 as RateTypeId,
            convert(varchar(64), '') as RateTypeName,
            convert(varchar(255), '') as RateTypeDescription

            GO

            CREATE view [SIR].[CurationStatus] as
            select 1 as CurationStatusId,
            convert(varchar(64), '') as CurationStatusName,
            convert(varchar(255), '') as CurationStatusDescription

            GO   