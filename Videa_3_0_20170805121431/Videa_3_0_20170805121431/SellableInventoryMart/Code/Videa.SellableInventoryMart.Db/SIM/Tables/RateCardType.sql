CREATE TABLE [SIM].[RateCardType] (
    [RateCardTypeHashKey] CHAR (32)     NOT NULL,
    [RateCardTypeSqn]     INT           NOT NULL,
    [RateCardTypeName]    VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_SIM_RateCardType_RateCardTypeHashKey] PRIMARY KEY CLUSTERED ([RateCardTypeHashKey] ASC)
);

