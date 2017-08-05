CREATE PROCEDURE SIRApi.CurationStatusAddUpdate
@CurationStatusId INT, @CurationStatusName VARCHAR (64), @CurationStatusDescription VARCHAR (255)
AS
SET NOCOUNT ON;
SET XACT_ABORT ON;
DECLARE @Output TABLE (
    Action           VARCHAR (20),
    CurationStatusId INT         );
MERGE INTO [SIR].[CurationStatus] WITH (HOLDLOCK)
 AS T
USING (SELECT @CurationStatusId AS CurationStatusId,
              @CurationStatusName AS CurationStatusName,
              @CurationStatusDescription AS CurationStatusDescription) AS NEW_T ON T.CurationStatusId = NEW_T.CurationStatusId
WHEN MATCHED THEN UPDATE 
SET T.CurationStatusName        = NEW_T.CurationStatusName,
    T.CurationStatusDescription = NEW_T.CurationStatusDescription
WHEN NOT MATCHED THEN INSERT (CurationStatusId, CurationStatusName, CurationStatusDescription) VALUES (NEW_T.CurationStatusId, NEW_T.CurationStatusName, NEW_T.CurationStatusDescription)
OUTPUT $ACTION, inserted.CurationStatusId AS 'CurationStatusId' INTO @Output;
SELECT Action,
       CurationStatusId
FROM   @Output;