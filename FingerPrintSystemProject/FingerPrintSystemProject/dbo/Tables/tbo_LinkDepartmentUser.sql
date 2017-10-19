CREATE TABLE [dbo].[tbo_LinkDepartmentUser] (
    [DepartmentID] INT           NOT NULL,
    [UserID]       INT           NOT NULL,
    [Access]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tbo_LinkDepartmentUser] PRIMARY KEY CLUSTERED ([DepartmentID] ASC, [UserID] ASC),
    CONSTRAINT [FK_tbo_LinkDepartmentUser_tbo_Department] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[tbo_Department] ([ID]),
    CONSTRAINT [FK_tbo_LinkDepartmentUser_tbo_Profile] FOREIGN KEY ([UserID]) REFERENCES [dbo].[tbo_Profile] ([ID])
);

