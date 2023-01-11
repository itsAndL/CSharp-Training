CREATE VIEW dbo.FullProfile
	AS 

select  p.Name, p.Age, p.Residence, p.Citizenship, p.MaritalStatus, 
		p.Children, p.Education, p.ImageSource,
		r.Rank, r.NetWorth, r.Source, r.Industry
from dbo.Profile p join dbo.Ranking r on p.ProfileID = r.ProfileID
