﻿CREATE TABLE [dbo].[tbo_Profile] (
    [ID]          INT   NOT NULL IDENTITY(1,1),
    [Name]        NVARCHAR (50) NOT NULL,
    [Surname]     NVARCHAR (50) NOT NULL,
    [Patronymic]  NVARCHAR (50) NOT NULL,
    [Photo]       IMAGE         NULL,
    [BirthDate]   DATE NOT NULL,
    [Schedule]    NVARCHAR (50) NOT NULL,
    [FingerPrint] NVARCHAR (50) NOT NULL,
    [Password]    NVARCHAR (50) NULL,
    [RoleID]      INT           NOT NULL,
    [DateCreation] DATE NULL, 
    CONSTRAINT [PK_tbo_Profile_1] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tbo_Profile_tbo_Role] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[tbo_Role] ([ID])
);

