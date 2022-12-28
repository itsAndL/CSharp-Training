using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


using AppLibrary;

namespace AppUI
{
    /// <summary>
    /// Interaction logic for CarsInOurStock.xaml
    /// </summary>
    public partial class CarsInOurStock : Window
    {
        public string filePath = @"c:\users\lenovo\source\repos\carsinouragencystock\appui\carsinourstockdata.csv";
        public List<Car> cars;
        public Car newCar;
        public CarsInOurStock()
        {
            InitializeComponent();

            MyListBoxDropdown();
        }
        private void MyListBoxDropdown()
        {
            cars = AccessCarsData.LoadCarsData(filePath);
            myListBox.ItemsSource = cars;
        }
        private void saveTheNewCarButton_Click(object sender, RoutedEventArgs e)
        {
            newCar = new()
            {
                Year = int.Parse(yearText.Text),
                Make = ConvertingString.ToCarBrand(makeText.Text),
                Model = modelText.Text,
                Miles = double.Parse(milesText.Text),
                ZIP = int.Parse(zipText.Text),
                ImageSource= imageSourceText.Text,
                ExteriorColor = System.Drawing.Color.FromName(exteriorColorText.Text),
                InteriorColor = System.Drawing.Color.FromName(interiorColorText.Text),
                Condition = ConvertingString.ToCarCondition(conditionText.Text)
            };

            AccessCarsData.AddNewCar(filePath, newCar);

            yearText.Text = "";
            makeText.Text = "";
            modelText.Text = "";
            milesText.Text = "";
            zipText.Text = "";
            imageSourceText.Text = "";
            exteriorColorText.Text = "";
            interiorColorText.Text = "";
            conditionText.Text = "";

            MyListBoxDropdown();
        }
    }
}
