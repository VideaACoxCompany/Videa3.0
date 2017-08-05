CREATE TABLE [SIRg].[CuratedRating] (
    [CuratedRatingId]          BIGINT        IDENTITY (1000, 1) NOT NULL,
    [SellableInventoryHashKey] CHAR (32)     NOT NULL,
    [RatingHashKey]            CHAR (32)     NOT NULL,
    [RatingVersion]            INT           NOT NULL,
    [IsDynamicRating]          BIT           NOT NULL,
    [CuratingRatingValue]      DECIMAL (18)  NOT NULL,
    [RatingTypeId]             INT           NOT NULL,
    [CurationStatusId]         INT           NOT NULL,
    [CreatedDateUtc]           DATETIME2 (7) NOT NULL,
    [CreatedBy]                VARCHAR (255) NOT NULL,
    [ModifiedDateUtc]          DATETIME2 (7) NULL,
    [ModifiedBy]               VARCHAR (255) NULL,
    [RowVersion]               TIMESTAMP     NOT NULL,
    CONSTRAINT [PK_SIRg_CuratedRating_CuratedRatingId] PRIMARY KEY CLUSTERED ([CuratedRatingId] ASC),
    FOREIGN KEY ([CurationStatusId]) REFERENCES [SIRg].[CurationStatus] ([CurationStatusId]),
    FOREIGN KEY ([RatingTypeId]) REFERENCES [SIRg].[RatingType] ([RatingTypeId])
);

