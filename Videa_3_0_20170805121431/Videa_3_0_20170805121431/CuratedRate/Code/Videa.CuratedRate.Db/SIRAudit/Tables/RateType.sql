CREATE TABLE [SIRAudit].[RateType] (
    [RateTypeId]          INT           NOT NULL,
    [RateTypeName]        VARCHAR (64)  NOT NULL,
    [RateTypeDescription] VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_SIRAudit_RateType_RateTypeId] PRIMARY KEY CLUSTERED ([RateTypeId] ASC)
);

