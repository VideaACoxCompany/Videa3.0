CREATE TABLE [TrafficStatistic].[RatePeriod] (
    [RatePeriodHashKey]   CHAR (32)     NOT NULL,
    [RatePeriodSqn]       INT           IDENTITY (1000, 1) NOT NULL,
    [RatePeriodName]      VARCHAR (255) NOT NULL,
    [RatePeriodStartDate] DATETIME2 (7) NOT NULL,
    [RatePeriodEndDate]   DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_TrafficStatistic_RatePeriod_RatePeriodHashKey] PRIMARY KEY CLUSTERED ([RatePeriodHashKey] ASC)
);

