using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPITUSLibrary.Models
{
    public class ProfileModel
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Residence { get; set; }
        public string? Citizenship { get; set; }
        public string? MaritalStatus { get; set; }
        public int Children { get; set; }
        public string? Education { get; set; }
        public string? ImageSource { get; set; }
        public int Rank { get; set; }
        public string? NetWorth { get; set; }
        public string? Source { get; set; }
        public string? Industry { get; set; }
    }
}
