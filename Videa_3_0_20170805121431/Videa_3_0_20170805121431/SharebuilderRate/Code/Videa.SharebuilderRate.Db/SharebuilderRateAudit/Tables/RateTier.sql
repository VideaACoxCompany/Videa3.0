﻿CREATE TABLE [SharebuilderRateAudit].[RateTier] (
    [RateTierHashKey] CHAR (32)     NOT NULL UNIQUE NONCLUSTERED ([RateTierHashKey] ASC),
    [RateTierSqn]     INT           IDENTITY (1000, 1) NOT NULL,
    [RateTierName]    VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_SharebuilderRateAudit_RateTier_RateTierHashKey] PRIMARY KEY CLUSTERED ([RateTierHashKey] ASC)
);

