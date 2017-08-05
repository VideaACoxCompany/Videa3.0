CREATE TABLE [InventoryGuideAudit].[SellingTitleDaysOfWeek] (
    [SellingTitleDaysOfWeekHashKey] CHAR (32)     NOT NULL,
    [SellingTitleDaysOfWeekSqn]     INT           NOT NULL,
    [SellingTitleDaysOfWeekName]    VARCHAR (255) NOT NULL,
    [Mon]                           BIT           NOT NULL,
    [Tue]                           BIT           NOT NULL,
    [Wed]                           BIT           NOT NULL,
    [Thu]                           BIT           NOT NULL,
    [Fri]                           BIT           NOT NULL,
    [Sat]                           BIT           NOT NULL,
    [Sun]                           BIT           NOT NULL,
    CONSTRAINT [PK_InventoryGuideAudit_SellingTitleDaysOfWeek_SellingTitleDaysOfWeekHashKey] PRIMARY KEY CLUSTERED ([SellingTitleDaysOfWeekHashKey] ASC)
);

