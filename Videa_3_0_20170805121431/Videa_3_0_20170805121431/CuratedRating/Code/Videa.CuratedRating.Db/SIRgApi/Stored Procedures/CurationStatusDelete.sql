CREATE PROCEDURE SIRgApi.CurationStatusDelete
@CurationStatusId INT
AS
DELETE [SIRg].[CurationStatus]
WHERE  CurationStatusId = @CurationStatusId;