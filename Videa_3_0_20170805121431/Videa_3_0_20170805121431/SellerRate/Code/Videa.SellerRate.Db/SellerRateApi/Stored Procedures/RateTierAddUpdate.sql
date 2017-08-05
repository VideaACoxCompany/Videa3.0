CREATE PROCEDURE SellerRateApi.RateTierAddUpdate
@RateTierHashKey CHAR (32), @RateTierSqn INT, @RateTierName VARCHAR (255)
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action          VARCHAR (20),
    RateTierHashKey CHAR (32)   );
MERGE INTO [SellerRate].[RateTier] WITH (HOLDLOCK)
 AS T
USING (SELECT @RateTierHashKey AS RateTierHashKey,
              @RateTierSqn AS RateTierSqn,
              @RateTierName AS RateTierName) AS NEW_T ON T.RateTierHashKey = NEW_T.RateTierHashKey
WHEN MATCHED THEN UPDATE 
SET T.RateTierName = NEW_T.RateTierName
WHEN NOT MATCHED THEN INSERT (RateTierHashKey, RateTierName) VALUES (NEW_T.RateTierHashKey, NEW_T.RateTierName)
OUTPUT $ACTION, inserted.RateTierHashKey AS 'RateTierHashKey' INTO @Output;
SELECT Action,
       RateTierHashKey
FROM   @Output;