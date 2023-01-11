CREATE PROCEDURE dbo.InsertProfile
	@Name NVARCHAR (50),
	@Age int,
	@Residence NVARCHAR (50),
	@Citizenship NVARCHAR (50),
	@MaritalStatus NVARCHAR (50),
	@Children INT,
	@Education NVARCHAR (70),
	@ImageSource VARCHAR (300),
	@Rank int,
	@NetWorth NVARCHAR (50),
	@Source NVARCHAR (50),
	@Industry NVARCHAR (50)
AS

begin
	insert into dbo.Profile values(@Name, @Age, @Residence, @Citizenship, @MaritalStatus, 
	@Children, @Education, @ImageSource);

	insert into dbo.Ranking values(@Rank, @NetWorth, @Source, @Industry)
end
