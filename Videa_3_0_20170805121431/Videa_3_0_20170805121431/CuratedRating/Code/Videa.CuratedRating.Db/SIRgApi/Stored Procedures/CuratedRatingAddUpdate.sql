CREATE PROCEDURE SIRgApi.CuratedRatingAddUpdate
@CuratedRatingId BIGINT, @SellableInventoryHashKey CHAR (32), @RatingHashKey CHAR (32), @RatingVersion INT, @IsDynamicRating BIT, @CuratingRatingValue DECIMAL, @RatingTypeId INT, @CurationStatusId INT, @CreatedBy VARCHAR (255), @ModifiedBy VARCHAR (255), @RowVersion TIMESTAMP=NULL
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action          VARCHAR (20),
    CuratedRatingId BIGINT      ,
    RowVersion      BINARY (8)  );
MERGE INTO [SIRg].[CuratedRating] WITH (HOLDLOCK)
 AS T
USING (SELECT @CuratedRatingId AS CuratedRatingId,
              @SellableInventoryHashKey AS SellableInventoryHashKey,
              @RatingHashKey AS RatingHashKey,
              @RatingVersion AS RatingVersion,
              @IsDynamicRating AS IsDynamicRating,
              @CuratingRatingValue AS CuratingRatingValue,
              @RatingTypeId AS RatingTypeId,
              @CurationStatusId AS CurationStatusId,
              @CreatedBy AS CreatedBy,
              @ModifiedBy AS ModifiedBy,
              @RowVersion AS RowVersion) AS NEW_T ON T.CuratedRatingId = NEW_T.CuratedRatingId
WHEN MATCHED AND (NEW_T.RowVersion IS NULL
                  OR T.RowVersion = NEW_T.RowVersion) THEN UPDATE 
SET T.SellableInventoryHashKey = NEW_T.SellableInventoryHashKey,
    T.RatingHashKey            = NEW_T.RatingHashKey,
    T.RatingVersion            = NEW_T.RatingVersion,
    T.IsDynamicRating          = NEW_T.IsDynamicRating,
    T.CuratingRatingValue      = NEW_T.CuratingRatingValue,
    T.RatingTypeId             = NEW_T.RatingTypeId,
    T.CurationStatusId         = NEW_T.CurationStatusId,
    T.CreatedBy                = NEW_T.CreatedBy,
    T.ModifiedDateUtc          = GetUtcDate(),
    T.ModifiedBy               = NEW_T.ModifiedBy
WHEN NOT MATCHED AND NEW_T.CuratedRatingId = 0
                     AND NEW_T.RowVersion IS NULL THEN INSERT (SellableInventoryHashKey, RatingHashKey, RatingVersion, IsDynamicRating, CuratingRatingValue, RatingTypeId, CurationStatusId, CreatedDateUtc, CreatedBy, ModifiedDateUtc, ModifiedBy) VALUES (NEW_T.SellableInventoryHashKey, NEW_T.RatingHashKey, NEW_T.RatingVersion, NEW_T.IsDynamicRating, NEW_T.CuratingRatingValue, NEW_T.RatingTypeId, NEW_T.CurationStatusId, GetUtcDate(), NEW_T.CreatedBy, NULL, NEW_T.ModifiedBy)
OUTPUT $ACTION, inserted.CuratedRatingId AS 'CuratedRatingId', inserted.RowVersion AS 'RowVersion' INTO @Output;
SELECT Action,
       CuratedRatingId,
       RowVersion
FROM   @Output;