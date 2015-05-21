CREATE TABLE [dbo].[User] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Login]     NVARCHAR (50) NOT NULL,
    [Password]  NVARCHAR (50) NOT NULL,
    [Email]     NVARCHAR (50) NOT NULL,
    [Birthdate] DATE          NOT NULL,
    [IsPlayer]  BIT           NOT NULL,
    [Avatar]    IMAGE         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Test] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Question] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Content] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Option] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Content]    NVARCHAR (50) NULL,
    [QuestionId] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Option_Question] FOREIGN KEY ([QuestionId]) REFERENCES [dbo].[Question] ([Id])
);


CREATE TABLE [dbo].[TestItem] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [TestId]     INT NOT NULL,
    [QuestionId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TestItem_Test] FOREIGN KEY ([TestId]) REFERENCES [dbo].[Test] ([Id]),
    CONSTRAINT [FK_TestItem_Question] FOREIGN KEY ([QuestionId]) REFERENCES [dbo].[Question] ([Id])
);

CREATE TABLE [dbo].[Score] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [Value]  INT NULL,
    [UserId] INT NOT NULL,
    [TestId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Score_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id]),
    CONSTRAINT [FK_Score_Test] FOREIGN KEY ([TestId]) REFERENCES [dbo].[Test] ([Id])
);
