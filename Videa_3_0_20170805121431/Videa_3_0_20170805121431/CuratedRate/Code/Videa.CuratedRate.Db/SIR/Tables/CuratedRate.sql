CREATE TABLE [SIR].[CuratedRate] (
    [CuratedRateId]            BIGINT        IDENTITY (1000, 1) NOT NULL,
    [SellableInventoryHashKey] CHAR (32)     NOT NULL,
    [RateHashKey]              CHAR (32)     NOT NULL,
    [RateVersion]              INT           NOT NULL,
    [CuratedRateValue]         MONEY         NOT NULL,
    [IsDynamicRate]            BIT           NOT NULL,
    [RateTypeId]               INT           NOT NULL,
    [CurationStatusId]         INT           NOT NULL,
    [CreatedDateUtc]           DATETIME2 (7) NOT NULL,
    [CreatedBy]                VARCHAR (255) NOT NULL,
    [ModifiedDateUtc]          DATETIME2 (7) NULL,
    [ModifiedBy]               VARCHAR (255) NULL,
    [RowVersion]               TIMESTAMP     NOT NULL,
    CONSTRAINT [PK_SIR_CuratedRate_CuratedRateId] PRIMARY KEY CLUSTERED ([CuratedRateId] ASC),
    FOREIGN KEY ([CurationStatusId]) REFERENCES [SIR].[CurationStatus] ([CurationStatusId]),
    FOREIGN KEY ([RateTypeId]) REFERENCES [SIR].[RateType] ([RateTypeId])
);

