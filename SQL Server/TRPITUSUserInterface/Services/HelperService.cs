namespace TRPITUSUserInterface.Services
{
    public class HelperService
    {

        public static string GetConnString(string DbName)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration _configuration = builder.Build();

            return _configuration.GetConnectionString(DbName);
        }
    }
}
