using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TRPITUSUserInterface.Models
{
    // This is a front-end user interface model
    // so all the attributes are MVC core specific
    
    public class DisplayProfileModel
    {
        [Required(ErrorMessage = "You need to enter the name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "You need to enter the age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "You need to enter the residence")]
        public string? Residence { get; set; }

        [Required(ErrorMessage = "You need to enter the citizenship")]
        public string? Citizenship { get; set; }

        [Display(Name = "Marital Status")]
        [Required(ErrorMessage = "You need to enter the marital status")]
        public string? MaritalStatus { get; set; }

        [Required(ErrorMessage = "You need to enter the number of children")]
        public int Children { get; set; }

        [Required(ErrorMessage = "You need to enter the education")]
        public string? Education { get; set; }

        [Display(Name = "Image Source")]
        [Required(ErrorMessage = "You need to enter the image source")]
        //[DataType(DataType.Url)]
        [Url]
        public string? ImageSource { get; set; }

        [Required(ErrorMessage = "You need to enter the rank")]
        public int Rank { get; set; }

        [Display(Name = "Net Worth")]
        [Required(ErrorMessage = "You need to enter the net worth")]
        public string? NetWorth { get; set; }

        [Required(ErrorMessage = "You need to enter the source")]
        public string? Source { get; set; }

        [Required(ErrorMessage = "You need to enter the industry")]
        public string? Industry { get; set; }
    }
}
