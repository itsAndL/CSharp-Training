using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

using DemoLibrary;

namespace DemoAppUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string filePath = @"C:\Users\lenovo\source\repos\WPFDemoApp\DemoAppUI\Employees.csv";
        List<Employee> employees;
        public MainWindow()
        {
            InitializeComponent();
            NamesDropdown();
        }

        private void NamesDropdown()
        {
            employees = DataAccess.LoadEmployeesList(filePath);

            dropdown.ItemsSource = null;
            dropdown.ItemsSource = employees;
            dropdown.DisplayMemberPath= "FullName";
        }
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new() {
                FullName = fullNameText.Text,
                Department = departmnetText.Text,
                Job = jobText.Text,
                Email = emailText.Text
            };

            DataAccess.AddNewEmployee(filePath, employee);

            messageLabel.Content = $"{fullNameText.Text}'data add successfully";

            fullNameText.Text = "";
            departmnetText.Text = "";
            jobText.Text = "";
            emailText.Text = "";

            NamesDropdown();
        }
    }
}
