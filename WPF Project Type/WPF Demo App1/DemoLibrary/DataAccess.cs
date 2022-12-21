using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class DataAccess
    {
        public static void AddNewEmployee(string filePath, Employee employee)
        {
            List<Employee> employees = LoadEmployeesList(filePath);

            employees.Add(employee);

            List<string> lines = new List<string>();
            lines.Add("Full Name,Department,Job,Email");

            foreach (var e in employees)
            {
                lines.Add($"{e.FullName},{e.Department},{e.Job},{e.Email.ToLower()}");
            }

            File.WriteAllLines(filePath, lines);
        }

        public static List<Employee> LoadEmployeesList(string filePath)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();

            if (lines.Count == 0) throw new Exception("The file is empty, at least one line");

            lines.RemoveAt(0);

            List<Employee> output = new List<Employee>();

            foreach (var line in lines)
            {
                string[] splits = line.Split(',');
                Employee e = new()
                {
                    FullName = splits[0],
                    Department = splits[1],
                    Job = splits[2],
                    Email = splits[3]
                };

                output.Add(e);

            }

            return output;
        }
    }
}
