CREATE TABLE [dbo].[tbo_Company] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [СompanyLogo] IMAGE         NOT NULL,
    CONSTRAINT [PK_tbo_Company] PRIMARY KEY CLUSTERED ([ID] ASC)
);



