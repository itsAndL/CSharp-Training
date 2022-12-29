using BuyAndSellACarLibrary.Models;
using System.Text.Json;

namespace BuyAndSellACarLibrary.DataAccess
{
    public static class AddNewCar
    {
        public static void Add(Car newCar)
        {
            string filePath = @"C:\Users\lenovo\source\repos\BuyAndSellACar\BuyAndSellACarUI\wwwroot\data\Cars.json";
        
            List<Car> listOfCars = LoadListOfCars.GetCars();
            listOfCars.Add(newCar);

            var serializing = JsonSerializer.Serialize<List<Car>>(listOfCars);

            File.WriteAllText(filePath, serializing);
        }
    }
}
