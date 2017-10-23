CREATE TABLE [dbo].[tbo_Company] (
    [ID]          INT  NOT NULL IDENTITY(1,1),
    [Name]        NVARCHAR (50) NOT NULL,
    [СompanyLogo] IMAGE         NULL,
    CONSTRAINT [PK_tbo_Company] PRIMARY KEY CLUSTERED ([ID] ASC)
	
);

