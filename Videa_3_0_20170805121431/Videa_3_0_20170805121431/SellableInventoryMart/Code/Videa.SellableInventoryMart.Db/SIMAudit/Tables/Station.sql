CREATE TABLE [SIMAudit].[Station] (
    [StationHashKey]     CHAR (32)     NOT NULL UNIQUE NONCLUSTERED ([StationHashKey] ASC),
    [StationSqn]         INT           IDENTITY (1000, 1) NOT NULL,
    [StationName]        VARCHAR (255) NOT NULL,
    [StationCallLetters] VARCHAR (10)  NOT NULL,
    CONSTRAINT [PK_SIMAudit_Station_StationHashKey] PRIMARY KEY CLUSTERED ([StationHashKey] ASC)
);

