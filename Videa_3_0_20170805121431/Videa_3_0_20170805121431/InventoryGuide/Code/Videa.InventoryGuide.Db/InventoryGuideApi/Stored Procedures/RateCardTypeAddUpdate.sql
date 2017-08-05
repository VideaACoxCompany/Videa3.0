CREATE PROCEDURE InventoryGuideApi.RateCardTypeAddUpdate
@RateCardTypeHashKey CHAR (32), @RateCardTypeSqn INT, @RateCardTypeName VARCHAR (255)
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action              VARCHAR (20),
    RateCardTypeHashKey CHAR (32)   );
MERGE INTO [InventoryGuide].[RateCardType] WITH (HOLDLOCK)
 AS T
USING (SELECT @RateCardTypeHashKey AS RateCardTypeHashKey,
              @RateCardTypeSqn AS RateCardTypeSqn,
              @RateCardTypeName AS RateCardTypeName) AS NEW_T ON T.RateCardTypeHashKey = NEW_T.RateCardTypeHashKey
WHEN MATCHED THEN UPDATE 
SET T.RateCardTypeSqn  = NEW_T.RateCardTypeSqn,
    T.RateCardTypeName = NEW_T.RateCardTypeName
WHEN NOT MATCHED THEN INSERT (RateCardTypeHashKey, RateCardTypeSqn, RateCardTypeName) VALUES (NEW_T.RateCardTypeHashKey, NEW_T.RateCardTypeSqn, NEW_T.RateCardTypeName)
OUTPUT $ACTION, inserted.RateCardTypeHashKey AS 'RateCardTypeHashKey' INTO @Output;
SELECT Action,
       RateCardTypeHashKey
FROM   @Output;