CREATE PROCEDURE SIRApi.CuratedRateAddUpdate
@CuratedRateId BIGINT, @SellableInventoryHashKey CHAR (32), @RateHashKey CHAR (32), @RateVersion INT, @CuratedRateValue MONEY, @IsDynamicRate BIT, @RateTypeId INT, @CurationStatusId INT, @CreatedBy VARCHAR (255), @ModifiedBy VARCHAR (255), @RowVersion TIMESTAMP=NULL
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action        VARCHAR (20),
    CuratedRateId BIGINT      ,
    RowVersion    BINARY (8)  );
MERGE INTO [SIR].[CuratedRate] WITH (HOLDLOCK)
 AS T
USING (SELECT @CuratedRateId AS CuratedRateId,
              @SellableInventoryHashKey AS SellableInventoryHashKey,
              @RateHashKey AS RateHashKey,
              @RateVersion AS RateVersion,
              @CuratedRateValue AS CuratedRateValue,
              @IsDynamicRate AS IsDynamicRate,
              @RateTypeId AS RateTypeId,
              @CurationStatusId AS CurationStatusId,
              @CreatedBy AS CreatedBy,
              @ModifiedBy AS ModifiedBy,
              @RowVersion AS RowVersion) AS NEW_T ON T.CuratedRateId = NEW_T.CuratedRateId
WHEN MATCHED AND (NEW_T.RowVersion IS NULL
                  OR T.RowVersion = NEW_T.RowVersion) THEN UPDATE 
SET T.SellableInventoryHashKey = NEW_T.SellableInventoryHashKey,
    T.RateHashKey              = NEW_T.RateHashKey,
    T.RateVersion              = NEW_T.RateVersion,
    T.CuratedRateValue         = NEW_T.CuratedRateValue,
    T.IsDynamicRate            = NEW_T.IsDynamicRate,
    T.RateTypeId               = NEW_T.RateTypeId,
    T.CurationStatusId         = NEW_T.CurationStatusId,
    T.CreatedBy                = NEW_T.CreatedBy,
    T.ModifiedDateUtc          = GetUtcDate(),
    T.ModifiedBy               = NEW_T.ModifiedBy
WHEN NOT MATCHED AND NEW_T.CuratedRateId = 0
                     AND NEW_T.RowVersion IS NULL THEN INSERT (SellableInventoryHashKey, RateHashKey, RateVersion, CuratedRateValue, IsDynamicRate, RateTypeId, CurationStatusId, CreatedDateUtc, CreatedBy, ModifiedDateUtc, ModifiedBy) VALUES (NEW_T.SellableInventoryHashKey, NEW_T.RateHashKey, NEW_T.RateVersion, NEW_T.CuratedRateValue, NEW_T.IsDynamicRate, NEW_T.RateTypeId, NEW_T.CurationStatusId, GetUtcDate(), NEW_T.CreatedBy, NULL, NEW_T.ModifiedBy)
OUTPUT $ACTION, inserted.CuratedRateId AS 'CuratedRateId', inserted.RowVersion AS 'RowVersion' INTO @Output;
SELECT Action,
       CuratedRateId,
       RowVersion
FROM   @Output;