using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Employee
    {
        public required string FullName { get; set; }
        public required string Department { get; set; }
        public required string Job { get; set; }
        public required string Email { get; set; }
    }
}
