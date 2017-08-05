CREATE PROCEDURE SIRApi.RateTypeDelete
@RateTypeId INT
AS
DELETE [SIR].[RateType]
WHERE  RateTypeId = @RateTypeId;