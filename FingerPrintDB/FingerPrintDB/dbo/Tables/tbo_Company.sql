CREATE TABLE [dbo].[tbo_Company] (
    [Company_ID]  INT           NOT NULL,
    [User_ID]     INT           NOT NULL,
    [NameCompany] NVARCHAR (50) NOT NULL,
    [Employees]   INT           NOT NULL,
    [Emblem]      IMAGE         NULL,
    CONSTRAINT [PK_tbo_Company] PRIMARY KEY CLUSTERED ([Company_ID] ASC),
    CONSTRAINT [FK_tbo_Company_tbo_Profile] FOREIGN KEY ([User_ID]) REFERENCES [dbo].[tbo_Profile] ([User_ID])
);

