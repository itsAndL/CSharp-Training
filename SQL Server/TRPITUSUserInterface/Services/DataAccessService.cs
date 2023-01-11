using System.Data;
using TRPITUSUserInterface.Models;
using Dapper;

namespace TRPITUSUserInterface.Services
{
    public class DataAccessService
    {
        public List<Profile> GetProfiles()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(HelperService.GetConnString("TRPITUS")))
            {
                return connection.Query<Profile>("dbo.GetFullProfiles").ToList();
            }
        }

        public void InsertProfile(Profile newProfile)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(HelperService.GetConnString("TRPITUS")))
            {
                List<Profile> profiles = new() { newProfile };

                connection.Execute("dbo.InsertProfile @Name, @Age, @Residence, @Citizenship, @MaritalStatus, @Children, @Education, @ImageSource, @Rank, @NetWorth, @Source, @Industry", profiles);
            }
        }
    }
}
