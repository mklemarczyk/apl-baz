--
-- Database: `apl-baz-pr3`
--

-- --------------------------------------------------------

--
-- Table structure for table `question`
--

CREATE TABLE [dbo].[Questions] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Content] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- --------------------------------------------------------

--
-- Table structure for table `options`
--

CREATE TABLE [dbo].[Options] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Content]     NVARCHAR (50) NULL,
    [Is_Correct]  INT           NOT NULL,
    [Question_Id] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Option_Question] FOREIGN KEY ([Question_Id]) REFERENCES [dbo].[Questions] ([Id])
);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE [dbo].[Users] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Login]     NVARCHAR (50) NOT NULL,
    [Password]  NVARCHAR (50) NOT NULL,
    [Email]     NVARCHAR (50) NOT NULL,
    [Birthdate] DATE          NOT NULL,
    [Is_Player] BIT           NOT NULL,
    [Avatar]    IMAGE         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- --------------------------------------------------------

--
-- Table structure for table `test`
--

CREATE TABLE [dbo].[Tests] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [User_Id] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Test_User] FOREIGN KEY ([User_Id]) REFERENCES [dbo].[Users] ([Id])
);

-- --------------------------------------------------------

--
-- Table structure for table `test_item`
--

CREATE TABLE [dbo].[Test_Items] (
    [Id]          INT IDENTITY (1, 1) NOT NULL,
    [Test_Id]     INT NOT NULL,
    [Question_Id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TestItem_Test] FOREIGN KEY ([Test_Id]) REFERENCES [dbo].[Tests] ([Id]),
    CONSTRAINT [FK_TestItem_Question] FOREIGN KEY ([Question_Id]) REFERENCES [dbo].[Questions] ([Id])
);

-- --------------------------------------------------------

--
-- Table structure for table `score`
--

CREATE TABLE [dbo].[Scores] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [Value]   INT NULL,
    [User_Id] INT NOT NULL,
    [Test_Id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Score_User] FOREIGN KEY ([User_Id]) REFERENCES [dbo].[Users] ([Id]),
    CONSTRAINT [FK_Score_Test] FOREIGN KEY ([Test_Id]) REFERENCES [dbo].[Tests] ([Id])
);

