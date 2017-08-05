CREATE PROCEDURE SIRApi.RateTypeAddUpdate
@RateTypeId INT, @RateTypeName VARCHAR (64), @RateTypeDescription VARCHAR (255)
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action     VARCHAR (20),
    RateTypeId INT         );
MERGE INTO [SIR].[RateType] WITH (HOLDLOCK)
 AS T
USING (SELECT @RateTypeId AS RateTypeId,
              @RateTypeName AS RateTypeName,
              @RateTypeDescription AS RateTypeDescription) AS NEW_T ON T.RateTypeId = NEW_T.RateTypeId
WHEN MATCHED THEN UPDATE 
SET T.RateTypeName        = NEW_T.RateTypeName,
    T.RateTypeDescription = NEW_T.RateTypeDescription
WHEN NOT MATCHED THEN INSERT (RateTypeId, RateTypeName, RateTypeDescription) VALUES (NEW_T.RateTypeId, NEW_T.RateTypeName, NEW_T.RateTypeDescription)
OUTPUT $ACTION, inserted.RateTypeId AS 'RateTypeId' INTO @Output;
SELECT Action,
       RateTypeId
FROM   @Output;