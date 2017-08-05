EXEC [SIRgApi].[CurationStatusAddUpdate]
CurationStatusId = 1
,CurationStatusName = 'Optional'
,CurationStatusDescription = 'Has not been curated'

GO

EXEC [SIRgApi].[CurationStatusAddUpdate]
CurationStatusId = 2
,CurationStatusName = 'Selected'
,CurationStatusDescription = 'Has been curated by system'

GO

EXEC [SIRgApi].[CurationStatusAddUpdate]
CurationStatusId = 3
,CurationStatusName = 'Confirmed by User'
,CurationStatusDescription = 'Has been confirmed by user'

GO

