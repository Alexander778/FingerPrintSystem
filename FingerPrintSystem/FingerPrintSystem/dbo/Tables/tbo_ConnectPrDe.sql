CREATE TABLE [dbo].[tbo_ConnectPrDe] (
    [Department_ID] INT NOT NULL,
    [User_ID]       INT NOT NULL,
    CONSTRAINT [PK_tbo_Example] PRIMARY KEY CLUSTERED ([User_ID] ASC),
    CONSTRAINT [FK_tbo_Example_tbo_Department] FOREIGN KEY ([Department_ID]) REFERENCES [dbo].[tbo_Department] ([Department_ID]),
    CONSTRAINT [FK_tbo_Example_tbo_Profile] FOREIGN KEY ([User_ID]) REFERENCES [dbo].[tbo_Profile] ([User_ID])
);

