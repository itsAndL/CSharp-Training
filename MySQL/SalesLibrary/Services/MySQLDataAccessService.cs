using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace SalesLibrary.Services
{
    public class MySQLDataAccessService : IMySQLDataAccessService
    {
        public async Task<List<T>> ReadData<T, U>(string sql, U parameters)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString()))
            {
                var output = await connection.QueryAsync<T>(sql, parameters);

                return output.ToList();
            }
        }

        // C : Create
        // U : Update
        // D : Delete
        public Task CUDData<T>(string sql, T parameters)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString()))
            {
                return connection.ExecuteAsync(sql, parameters);
            }
        }

        private string GetConnectionString(string dbName = "default")
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            return configuration.GetConnectionString(dbName);
        }
    }
}
