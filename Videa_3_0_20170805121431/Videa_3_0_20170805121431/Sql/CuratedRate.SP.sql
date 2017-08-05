CREATE PROCEDURE SIRApi.GetConfirmedRates
(
@SellableInventoryList [ttSellableInventory] READONLY
)
AS
SELECT SellableInventoryHashKey,
       RateHashKey
FROM   [SIR].[CuratedRate]
WHERE  [SellableInventoryHashKey] IN (SELECT SellableInventoryHashKey
                                      FROM   @SellableInventoryList)
       AND CurationStatusId = 3 -- 'confirmed'
	   AND RateVersion = 1

    
GO

