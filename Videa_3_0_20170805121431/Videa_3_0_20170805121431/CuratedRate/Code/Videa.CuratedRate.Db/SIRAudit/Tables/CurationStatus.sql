CREATE TABLE [SIRAudit].[CurationStatus] (
    [CurationStatusId]          INT           NOT NULL,
    [CurationStatusName]        VARCHAR (64)  NOT NULL,
    [CurationStatusDescription] VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_SIRAudit_CurationStatus_CurationStatusId] PRIMARY KEY CLUSTERED ([CurationStatusId] ASC)
);

