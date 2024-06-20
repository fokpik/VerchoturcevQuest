
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/19/2024 16:07:30
-- Generated from EDMX file: C:\Users\ser14\source\repos\TSTSystem\VerchoturcevQuest\TestDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Answer_ToQuestion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GAnswer] DROP CONSTRAINT [FK_Answer_ToQuestion];
GO
IF OBJECT_ID(N'[dbo].[FK_Question_ToTest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GQuestion] DROP CONSTRAINT [FK_Question_ToTest];
GO
IF OBJECT_ID(N'[dbo].[FK_TestResult_ToTest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GTestResult] DROP CONSTRAINT [FK_TestResult_ToTest];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[GAnswer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GAnswer];
GO
IF OBJECT_ID(N'[dbo].[GQuestion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GQuestion];
GO
IF OBJECT_ID(N'[dbo].[GTest]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GTest];
GO
IF OBJECT_ID(N'[dbo].[GTestResult]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GTestResult];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'GAnswer'
CREATE TABLE [dbo].[GAnswer] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(100)  NULL,
    [IsCorrect] bit  NOT NULL,
    [IDqs] int  NOT NULL
);
GO

-- Creating table 'GQuestion'
CREATE TABLE [dbo].[GQuestion] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(300)  NULL,
    [Type] int  NOT NULL,
    [IDts] int  NOT NULL
);
GO

-- Creating table 'GTest'
CREATE TABLE [dbo].[GTest] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'GTestResult'
CREATE TABLE [dbo].[GTestResult] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(70)  NOT NULL,
    [Group] nvarchar(10)  NULL,
    [Date] datetime  NOT NULL,
    [Result] int  NOT NULL,
    [IDts] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'GAnswer'
ALTER TABLE [dbo].[GAnswer]
ADD CONSTRAINT [PK_GAnswer]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'GQuestion'
ALTER TABLE [dbo].[GQuestion]
ADD CONSTRAINT [PK_GQuestion]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'GTest'
ALTER TABLE [dbo].[GTest]
ADD CONSTRAINT [PK_GTest]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'GTestResult'
ALTER TABLE [dbo].[GTestResult]
ADD CONSTRAINT [PK_GTestResult]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IDqs] in table 'GAnswer'
ALTER TABLE [dbo].[GAnswer]
ADD CONSTRAINT [FK_Answer_ToQuestion]
    FOREIGN KEY ([IDqs])
    REFERENCES [dbo].[GQuestion]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Answer_ToQuestion'
CREATE INDEX [IX_FK_Answer_ToQuestion]
ON [dbo].[GAnswer]
    ([IDqs]);
GO

-- Creating foreign key on [IDts] in table 'GQuestion'
ALTER TABLE [dbo].[GQuestion]
ADD CONSTRAINT [FK_Question_ToTest]
    FOREIGN KEY ([IDts])
    REFERENCES [dbo].[GTest]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Question_ToTest'
CREATE INDEX [IX_FK_Question_ToTest]
ON [dbo].[GQuestion]
    ([IDts]);
GO

-- Creating foreign key on [IDts] in table 'GTestResult'
ALTER TABLE [dbo].[GTestResult]
ADD CONSTRAINT [FK_TestResult_ToTest]
    FOREIGN KEY ([IDts])
    REFERENCES [dbo].[GTest]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestResult_ToTest'
CREATE INDEX [IX_FK_TestResult_ToTest]
ON [dbo].[GTestResult]
    ([IDts]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------