CREATE PROCEDURE SIMApi.SellingTitleAddUpdate
@SellingTitleHashKey CHAR (32), @SellingTitleSqn INT, @SellingTitleName VARCHAR (255), @SellingTitleStartDate DATETIME2, @SellingTitleEndDate DATETIME2
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action              VARCHAR (20),
    SellingTitleHashKey CHAR (32)   );
MERGE INTO [SIM].[SellingTitle] WITH (HOLDLOCK)
 AS T
USING (SELECT @SellingTitleHashKey AS SellingTitleHashKey,
              @SellingTitleSqn AS SellingTitleSqn,
              @SellingTitleName AS SellingTitleName,
              @SellingTitleStartDate AS SellingTitleStartDate,
              @SellingTitleEndDate AS SellingTitleEndDate) AS NEW_T ON T.SellingTitleHashKey = NEW_T.SellingTitleHashKey
WHEN MATCHED THEN UPDATE 
SET T.SellingTitleName      = NEW_T.SellingTitleName,
    T.SellingTitleStartDate = NEW_T.SellingTitleStartDate,
    T.SellingTitleEndDate   = NEW_T.SellingTitleEndDate
WHEN NOT MATCHED THEN INSERT (SellingTitleHashKey, SellingTitleName, SellingTitleStartDate, SellingTitleEndDate) VALUES (NEW_T.SellingTitleHashKey, NEW_T.SellingTitleName, NEW_T.SellingTitleStartDate, NEW_T.SellingTitleEndDate)
OUTPUT $ACTION, inserted.SellingTitleHashKey AS 'SellingTitleHashKey' INTO @Output;
SELECT Action,
       SellingTitleHashKey
FROM   @Output;