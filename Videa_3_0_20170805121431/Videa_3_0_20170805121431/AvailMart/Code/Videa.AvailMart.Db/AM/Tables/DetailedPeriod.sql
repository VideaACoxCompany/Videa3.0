CREATE TABLE [AM].[DetailedPeriod] (
    [DetailedPeriodHashKey]               CHAR (32)     NOT NULL,
    [DetailedPeriodSqn]                   INT           IDENTITY (1000, 1) NOT NULL,
    [AvailLineWithDetailedPeriodsHashKey] CHAR (32)     NOT NULL,
    [StartDate]                           DATETIME2 (7) NOT NULL,
    [EndDate]                             DATETIME2 (7) NOT NULL,
    [Rate]                                MONEY         NOT NULL,
    CONSTRAINT [PK_AM_DetailedPeriod_DetailedPeriodHashKey] PRIMARY KEY CLUSTERED ([DetailedPeriodHashKey] ASC),
    FOREIGN KEY ([AvailLineWithDetailedPeriodsHashKey]) REFERENCES [AvailMart].[AvailLineWithDetailedPeriods] ([AvailLineWithDetailedPeriodsHashKey])
);

