﻿CREATE TABLE [dbo].[TaskStates]
(
	[StateId] INT IDENTITY(1,1) NOT NULL,
	[StateName] NVARCHAR(50) NOT NULL,

	CONSTRAINT [PK_TaskStates] PRIMARY KEY CLUSTERED([StateId] ASC)
)