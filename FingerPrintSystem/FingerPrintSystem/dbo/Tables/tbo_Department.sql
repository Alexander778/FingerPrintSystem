CREATE TABLE [dbo].[tbo_Department] (
    [Department_ID]  INT           NOT NULL,
    [NameDepartment] NVARCHAR (50) NOT NULL,
    [Company_ID]     INT           NOT NULL,
    [Regime]         NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tbo_Department_1] PRIMARY KEY CLUSTERED ([Department_ID] ASC),
    CONSTRAINT [FK_tbo_Department_tbo_Company] FOREIGN KEY ([Company_ID]) REFERENCES [dbo].[tbo_Company] ([Company_ID])
);

