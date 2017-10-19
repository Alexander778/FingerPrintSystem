CREATE TABLE [dbo].[tbo_Department] (
    [ID]        INT           NOT NULL,
    [Name]      NVARCHAR (50) NOT NULL,
    [CompanyID] INT           NOT NULL,
    [Regime]    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tbo_Department_1] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tbo_Department_tbo_Company] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[tbo_Company] ([ID])
);

