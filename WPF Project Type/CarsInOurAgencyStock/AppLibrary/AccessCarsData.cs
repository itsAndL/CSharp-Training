using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary
{
    public static class AccessCarsData
    {
        public static List<Car> LoadCarsData(string filePath)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();

            if (lines.Count == 0) throw new Exception("The file is empty, at least one line");

            lines.RemoveAt(0);

            List<Car> output = new List<Car>();

            foreach (var line in lines)
            {
                string[] splits = line.Split(',');

                Car c = new()
                {
                    Year = int.Parse(splits[0]),
                    Make = ConvertingString.ToCarBrand(splits[1]),
                    Model = splits[2],
                    Miles = double.Parse(splits[3]),
                    ZIP = int.Parse(splits[4]),
                    ImageSource = splits[5],
                    ExteriorColor = Color.FromName(splits[6]),
                    InteriorColor = Color.FromName(splits[7]),
                    Condition = ConvertingString.ToCarCondition(splits[8])
                };

                output.Add(c);
            }
            return output;
        }

        public static void AddNewCar(string filePath, Car car)
        {
            List<Car> cars = LoadCarsData(filePath);

            cars.Add(car);

            List<string> lines = new List<string>();
            lines.Add("Year,Make,Model,Miles,ZIP,ImageSource,ExteriorColor,InteriorColor,Condition");

            foreach (var c in cars)
            {
                lines.Add($"{c.Year},{c.Make},{c.Model},{c.Miles},{c.ZIP},{c.ImageSource},{c.ExteriorColor},{c.InteriorColor},{c.Condition}");
            }

            File.WriteAllLines(filePath, lines);
        }
    }
}
