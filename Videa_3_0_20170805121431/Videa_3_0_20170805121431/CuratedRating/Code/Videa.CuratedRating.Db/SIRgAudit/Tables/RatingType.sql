CREATE TABLE [SIRgAudit].[RatingType] (
    [RatingTypeId]          INT           NOT NULL,
    [RatingTypeName]        VARCHAR (64)  NOT NULL,
    [RatingTypeDescription] VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_SIRgAudit_RatingType_RatingTypeId] PRIMARY KEY CLUSTERED ([RatingTypeId] ASC)
);

