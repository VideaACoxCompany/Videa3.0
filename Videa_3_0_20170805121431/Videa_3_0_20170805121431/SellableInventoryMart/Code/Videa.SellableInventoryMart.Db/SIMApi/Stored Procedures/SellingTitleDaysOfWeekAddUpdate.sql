CREATE PROCEDURE SIMApi.SellingTitleDaysOfWeekAddUpdate
@SellingTitleDaysOfWeekHashKey CHAR (32), @SellingTitleDaysOfWeekSqn INT, @SellingTitleDaysOfWeekName VARCHAR (255), @Mon BIT, @Tue BIT, @Wed BIT, @Thu BIT, @Fri BIT, @Sat BIT, @Sun BIT
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action                        VARCHAR (20),
    SellingTitleDaysOfWeekHashKey CHAR (32)   );
MERGE INTO [SIM].[SellingTitleDaysOfWeek] WITH (HOLDLOCK)
 AS T
USING (SELECT @SellingTitleDaysOfWeekHashKey AS SellingTitleDaysOfWeekHashKey,
              @SellingTitleDaysOfWeekSqn AS SellingTitleDaysOfWeekSqn,
              @SellingTitleDaysOfWeekName AS SellingTitleDaysOfWeekName,
              @Mon AS Mon,
              @Tue AS Tue,
              @Wed AS Wed,
              @Thu AS Thu,
              @Fri AS Fri,
              @Sat AS Sat,
              @Sun AS Sun) AS NEW_T ON T.SellingTitleDaysOfWeekHashKey = NEW_T.SellingTitleDaysOfWeekHashKey
WHEN MATCHED THEN UPDATE 
SET T.SellingTitleDaysOfWeekSqn  = NEW_T.SellingTitleDaysOfWeekSqn,
    T.SellingTitleDaysOfWeekName = NEW_T.SellingTitleDaysOfWeekName,
    T.Mon                        = NEW_T.Mon,
    T.Tue                        = NEW_T.Tue,
    T.Wed                        = NEW_T.Wed,
    T.Thu                        = NEW_T.Thu,
    T.Fri                        = NEW_T.Fri,
    T.Sat                        = NEW_T.Sat,
    T.Sun                        = NEW_T.Sun
WHEN NOT MATCHED THEN INSERT (SellingTitleDaysOfWeekHashKey, SellingTitleDaysOfWeekSqn, SellingTitleDaysOfWeekName, Mon, Tue, Wed, Thu, Fri, Sat, Sun) VALUES (NEW_T.SellingTitleDaysOfWeekHashKey, NEW_T.SellingTitleDaysOfWeekSqn, NEW_T.SellingTitleDaysOfWeekName, NEW_T.Mon, NEW_T.Tue, NEW_T.Wed, NEW_T.Thu, NEW_T.Fri, NEW_T.Sat, NEW_T.Sun)
OUTPUT $ACTION, inserted.SellingTitleDaysOfWeekHashKey AS 'SellingTitleDaysOfWeekHashKey' INTO @Output;
SELECT Action,
       SellingTitleDaysOfWeekHashKey
FROM   @Output;