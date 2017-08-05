﻿CREATE TABLE [InventoryGuide].[StationGroup] (
    [StationGroupHashKey] CHAR (32)     NOT NULL UNIQUE NONCLUSTERED ([StationGroupHashKey] ASC),
    [StationGroupSqn]     INT           IDENTITY (1000, 1) NOT NULL,
    [StationGroupName]    VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_InventoryGuide_StationGroup_StationGroupHashKey] PRIMARY KEY CLUSTERED ([StationGroupHashKey] ASC)
);

