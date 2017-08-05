CREATE PROCEDURE SIRApi.CurationStatusDelete
@CurationStatusId INT
AS
DELETE [SIR].[CurationStatus]
WHERE  CurationStatusId = @CurationStatusId;