using System.Configuration;

namespace TRPITUSUserInterface.Services
{
    public class HelperService
    {
        // Note: 
        //      You can use the method GetConnString(string DbName) with ( appsettings.json ) file
        //      or you can use the method CnnVal(string DbName) with ( App.config ) file

        public static string GetConnString(string DbName)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration _configuration = builder.Build();

            return _configuration.GetConnectionString(DbName);
        }

        //public static string CnnVal(string DbName)
        //{
        //    return ConfigurationManager.ConnectionStrings[DbName].ConnectionString;
        //}
    }
}
