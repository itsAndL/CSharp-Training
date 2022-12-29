using BuyAndSellACarLibrary.Models;
using System.Text.Json;

namespace BuyAndSellACarLibrary.DataAccess
{
    public static class LoadListOfCars
    {
        public static List<Car> GetCars() 
        {
            string filePath = @"C:\Users\lenovo\source\repos\BuyAndSellACar\BuyAndSellACarUI\wwwroot\data\Cars.json";

            var jsonFormat = File.OpenText(filePath);

            var deserializing = JsonSerializer.Deserialize<List<Car>>(jsonFormat.ReadToEnd());

            jsonFormat.Close();

            return deserializing;
        }
    }
}
