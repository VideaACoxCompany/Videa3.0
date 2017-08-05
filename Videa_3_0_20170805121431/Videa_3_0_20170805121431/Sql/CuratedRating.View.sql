CREATE view [SIRg].[CuratedRating] as 
            select 
            convert(bigint,1) as CuratedRatingId,
            convert(char(32),'') as SellableInventoryHashKey, 
            convert(char(32),'') as RatingHashKey, 
            convert(int, 1 ) as RatingVersion,
            convert(bit,1) as IsDynamicRating, --todo: create lookup table
			convert(decimal,1) as CuratingRatingValue,
            convert(int, 1) as RatingTypeId, 
            convert(int, 1) as CurationStatusId,
            convert(datetime2,getdate()) as CreatedDateUtc,
            convert(varchar(255),'user name') as CreatedBy,
            convert(datetime2,getdate()) as ModifiedDateUtc,
            convert(varchar(255),'user name who change') as ModifiedBy,
            convert(RowVersion,null) as RowVersion

            GO
                
            CREATE view [SIRg].[RatingType] as
            select 1 as RatingTypeId,
            convert(varchar(64), '') as RatingTypeName,
            convert(varchar(255), '') as RatingTypeDescription

            GO

            CREATE view [SIRg].[CurationStatus] as
            select 1 as CurationStatusId,
            convert(varchar(64), '') as CurationStatusName,
            convert(varchar(255), '') as CurationStatusDescription

            GO    