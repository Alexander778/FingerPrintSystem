CREATE TABLE [dbo].[tbo_Profile] (
    [ID]            INT           NOT NULL,
    [User_ID]       INT           NOT NULL,
    [Name]          NVARCHAR (50) NOT NULL,
    [Surname]       NVARCHAR (50) NOT NULL,
    [Patronymic]    NVARCHAR (50) NOT NULL,
    [Photo]         IMAGE         NULL,
    [Date of Birth] NVARCHAR (50) NOT NULL,
    [Company_ID]    INT           NOT NULL,
    [Schedule]      NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tbo_Profile_1] PRIMARY KEY CLUSTERED ([User_ID] ASC),
    CONSTRAINT [FK_tbo_Profile_tbo_User] FOREIGN KEY ([User_ID]) REFERENCES [dbo].[tbo_User] ([ID])
);

