using MicrosoftEmployeesLibrary;

namespace MicrosoftEmployeesUI
{
    public partial class microsoftEmployees : Form
    {
        private string filePath = @"C:\Users\lenovo\source\repos\MicrosoftEmployees\MicrosoftEmployeesUI\Employees.csv";
        List<Employee> employees;
        public microsoftEmployees()
        {
            InitializeComponent();
            NamesDropdown();
        }

        private void exitMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutMenuStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Demo Project.\nPretend that it manages employees of Microsoft.");
        }

        private void NamesDropdown()
        {
            employees = DataAccess.LoadEmployeesList(filePath);

            nameAllEmployeesDropdown.DataSource = null;
            nameAllEmployeesDropdown.DataSource = employees;
            nameAllEmployeesDropdown.DisplayMember = "FullName";
        }
        private void addEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new()
            {
                FullName = fullNameText.Text,
                Department = departmentText.Text,
                Job = jobText.Text,
                Email = emailText.Text
            };

            // We try here to know if the new employee if it exists in our data or not
            
            employees = DataAccess.LoadEmployeesList(filePath);
            foreach(var item in employees)
            {
                if (item.Email == employee.Email.ToLower()) 
                {
                    MessageBox.Show($"{employee.FullName} already in our data");

                    fullNameText.Text = "";
                    departmentText.Text = "";
                    jobText.Text = "";
                    emailText.Text = "";

                    goto EndOfMethod;
                }
            }

            DataAccess.AddNewEmployee(filePath, employee);

            fullNameText.Text = "";
            departmentText.Text = "";
            jobText.Text = "";
            emailText.Text = "";

            NamesDropdown();

            EndOfMethod:;
        }
    }
}
