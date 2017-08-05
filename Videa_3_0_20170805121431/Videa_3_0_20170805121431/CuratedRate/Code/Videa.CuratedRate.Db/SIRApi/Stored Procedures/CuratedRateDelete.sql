CREATE PROCEDURE SIRApi.CuratedRateDelete
@CuratedRateId BIGINT
AS
DELETE [SIR].[CuratedRate]
WHERE  CuratedRateId = @CuratedRateId;