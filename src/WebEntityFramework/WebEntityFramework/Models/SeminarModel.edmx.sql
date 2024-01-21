
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/05/2010 02:36:14
-- Generated from EDMX file: C:\EntityFramework\WebEntityFramework\WebEntityFramework\Models\SeminarModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Seminar];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Rooms'
CREATE TABLE [dbo].[Rooms] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Talks'
CREATE TABLE [dbo].[Talks] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [When] datetime  NULL,
    [RoomID] int  NOT NULL
);
GO

-- Creating table 'Speakers'
CREATE TABLE [dbo].[Speakers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TalkSpeaker'
CREATE TABLE [dbo].[TalkSpeaker] (
    [Talks_ID] int  NOT NULL,
    [Speakers_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Rooms'
ALTER TABLE [dbo].[Rooms]
ADD CONSTRAINT [PK_Rooms]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Talks'
ALTER TABLE [dbo].[Talks]
ADD CONSTRAINT [PK_Talks]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Speakers'
ALTER TABLE [dbo].[Speakers]
ADD CONSTRAINT [PK_Speakers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Talks_ID], [Speakers_ID] in table 'TalkSpeaker'
ALTER TABLE [dbo].[TalkSpeaker]
ADD CONSTRAINT [PK_TalkSpeaker]
    PRIMARY KEY NONCLUSTERED ([Talks_ID], [Speakers_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [RoomID] in table 'Talks'
ALTER TABLE [dbo].[Talks]
ADD CONSTRAINT [FK_RoomTalk]
    FOREIGN KEY ([RoomID])
    REFERENCES [dbo].[Rooms]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RoomTalk'
CREATE INDEX [IX_FK_RoomTalk]
ON [dbo].[Talks]
    ([RoomID]);
GO

-- Creating foreign key on [Talks_ID] in table 'TalkSpeaker'
ALTER TABLE [dbo].[TalkSpeaker]
ADD CONSTRAINT [FK_TalkSpeaker_Talk]
    FOREIGN KEY ([Talks_ID])
    REFERENCES [dbo].[Talks]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Speakers_ID] in table 'TalkSpeaker'
ALTER TABLE [dbo].[TalkSpeaker]
ADD CONSTRAINT [FK_TalkSpeaker_Speaker]
    FOREIGN KEY ([Speakers_ID])
    REFERENCES [dbo].[Speakers]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TalkSpeaker_Speaker'
CREATE INDEX [IX_FK_TalkSpeaker_Speaker]
ON [dbo].[TalkSpeaker]
    ([Speakers_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------