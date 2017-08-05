CREATE TABLE [AM].[AvailLineWithDetailedPeriods] (
    [AvailLineWithDetailedPeriodsHashKey] CHAR (32)     NOT NULL,
    [AvailLineWithDetailedPeriodsSqn]     INT           IDENTITY (1000, 1) NOT NULL,
    [AvailListHashKey]                    CHAR (32)     NOT NULL,
    [DaypartName]                         VARCHAR (255) NOT NULL,
    [AvailName]                           VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_AM_AvailLineWithDetailedPeriods_AvailLineWithDetailedPeriodsHashKey] PRIMARY KEY CLUSTERED ([AvailLineWithDetailedPeriodsHashKey] ASC),
    FOREIGN KEY ([AvailListHashKey]) REFERENCES [AvailMart].[AvailList] ([AvailListHashKey])
);

