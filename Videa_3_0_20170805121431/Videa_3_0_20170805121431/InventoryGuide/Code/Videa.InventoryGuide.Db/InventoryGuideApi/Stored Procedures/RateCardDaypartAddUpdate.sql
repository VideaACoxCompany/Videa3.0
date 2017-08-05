CREATE PROCEDURE InventoryGuideApi.RateCardDaypartAddUpdate
@RateCardDaypartHashKey CHAR (32), @RateCardDaypartSqn INT, @RateCardDaypartName VARCHAR (255)
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action                 VARCHAR (20),
    RateCardDaypartHashKey CHAR (32)   );
MERGE INTO [InventoryGuide].[RateCardDaypart] WITH (HOLDLOCK)
 AS T
USING (SELECT @RateCardDaypartHashKey AS RateCardDaypartHashKey,
              @RateCardDaypartSqn AS RateCardDaypartSqn,
              @RateCardDaypartName AS RateCardDaypartName) AS NEW_T ON T.RateCardDaypartHashKey = NEW_T.RateCardDaypartHashKey
WHEN MATCHED THEN UPDATE 
SET T.RateCardDaypartName = NEW_T.RateCardDaypartName
WHEN NOT MATCHED THEN INSERT (RateCardDaypartHashKey, RateCardDaypartName) VALUES (NEW_T.RateCardDaypartHashKey, NEW_T.RateCardDaypartName)
OUTPUT $ACTION, inserted.RateCardDaypartHashKey AS 'RateCardDaypartHashKey' INTO @Output;
SELECT Action,
       RateCardDaypartHashKey
FROM   @Output;