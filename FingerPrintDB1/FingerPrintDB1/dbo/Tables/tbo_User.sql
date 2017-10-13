CREATE TABLE [dbo].[tbo_User] (
    [ID]           INT           NOT NULL,
    [FingerPrint]  NVARCHAR (50) NOT NULL,
    [Creator]      NVARCHAR (50) NOT NULL,
    [CreationDate] DATE          NULL,
    [Role]         NVARCHAR (10) NOT NULL,
    [Password]     NVARCHAR (20) NOT NULL,
    CONSTRAINT [PK_tbo_User] PRIMARY KEY CLUSTERED ([ID] ASC)
);

