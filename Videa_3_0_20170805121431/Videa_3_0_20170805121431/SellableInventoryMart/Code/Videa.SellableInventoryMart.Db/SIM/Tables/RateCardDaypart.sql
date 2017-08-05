CREATE TABLE [SIM].[RateCardDaypart] (
    [RateCardDaypartHashKey] CHAR (32)     NOT NULL UNIQUE NONCLUSTERED ([RateCardDaypartHashKey] ASC),
    [RateCardDaypartSqn]     INT           IDENTITY (1000, 1) NOT NULL,
    [RateCardDaypartName]    VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_SIM_RateCardDaypart_RateCardDaypartHashKey] PRIMARY KEY CLUSTERED ([RateCardDaypartHashKey] ASC)
);

