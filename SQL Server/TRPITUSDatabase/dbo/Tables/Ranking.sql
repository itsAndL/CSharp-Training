CREATE TABLE [dbo].[Ranking] (
    [ProfileID] INT           IDENTITY (1, 1) NOT NULL,
    [Rank]      INT           NOT NULL,
    [NetWorth]  NVARCHAR (50) NOT NULL,
    [Source]    NVARCHAR (50) NOT NULL,
    [Industry]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [FK_Ranking_ProfileID] FOREIGN KEY ([ProfileID]) REFERENCES [dbo].[Profile] ([ProfileID])
);

