﻿CREATE TABLE [dbo].[tbo_Role] (
    [ID]   INT  NOT NULL IDENTITY(1,1),
    [Name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tbo_Role] PRIMARY KEY CLUSTERED ([ID] ASC)
);

