CREATE TABLE [dbo].[Profile] (
    [ProfileID]     INT           IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50) NOT NULL,
    [Age]           INT           NOT NULL,
    [Residence]     NVARCHAR (50) NOT NULL,
    [Citizenship]   NVARCHAR (50) NOT NULL,
    [MaritalStatus] NVARCHAR (50) NOT NULL,
    [Children]      INT           NOT NULL,
    [Education]     NVARCHAR (70) NOT NULL,
    [ImageSource]   VARCHAR (300) NOT NULL,
    CONSTRAINT [PK_Profile_ProfileID] PRIMARY KEY CLUSTERED ([ProfileID] ASC)
);

