CREATE PROCEDURE InventoryGuideApi.RateCardAddUpdate
@RateCardHashKey CHAR (32), @RateCardSqn INT, @RateCardName VARCHAR (255), @RateCardStartDate DATETIME2, @RateCardEndDate DATETIME2
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action          VARCHAR (20),
    RateCardHashKey CHAR (32)   );
MERGE INTO [InventoryGuide].[RateCard] WITH (HOLDLOCK)
 AS T
USING (SELECT @RateCardHashKey AS RateCardHashKey,
              @RateCardSqn AS RateCardSqn,
              @RateCardName AS RateCardName,
              @RateCardStartDate AS RateCardStartDate,
              @RateCardEndDate AS RateCardEndDate) AS NEW_T ON T.RateCardHashKey = NEW_T.RateCardHashKey
WHEN MATCHED THEN UPDATE 
SET T.RateCardName      = NEW_T.RateCardName,
    T.RateCardStartDate = NEW_T.RateCardStartDate,
    T.RateCardEndDate   = NEW_T.RateCardEndDate
WHEN NOT MATCHED THEN INSERT (RateCardHashKey, RateCardName, RateCardStartDate, RateCardEndDate) VALUES (NEW_T.RateCardHashKey, NEW_T.RateCardName, NEW_T.RateCardStartDate, NEW_T.RateCardEndDate)
OUTPUT $ACTION, inserted.RateCardHashKey AS 'RateCardHashKey' INTO @Output;
SELECT Action,
       RateCardHashKey
FROM   @Output;