CREATE TABLE [InventoryGuideAudit].[SellingTitleTimeRange] (
    [SellingTitleTimeRangeHashKey] CHAR (32)     NOT NULL,
    [TimeRangeSqn]                 INT           NOT NULL,
    [SellingTitleTimeRangeName]    VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_InventoryGuideAudit_SellingTitleTimeRange_SellingTitleTimeRangeHashKey] PRIMARY KEY CLUSTERED ([SellingTitleTimeRangeHashKey] ASC)
);

