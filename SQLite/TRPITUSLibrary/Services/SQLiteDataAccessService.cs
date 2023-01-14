using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SQLite;

namespace TRPITUSLibrary.Services
{
    public class SQLiteDataAccessService
    {
        public List<T> GetProfiles<T>(string? sql)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                return connection.Query<T>(sql).ToList();
            }
        }

        public void InsertProfile<T>(string? sql, T model)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString("Default")))
            {
                List<T> profiles = new() { model };

                connection.Execute(sql, profiles);
            }
        }

        private string LoadConnectionString(string name = "Default")
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();

            return _configuration.GetConnectionString(name);
        }
    }
}
