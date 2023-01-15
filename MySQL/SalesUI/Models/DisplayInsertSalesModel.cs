using System.ComponentModel.DataAnnotations;

namespace SalesUI.Models
{
    public class DisplayInsertSalesModel
    {
        [Required]
        public string SellerId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Sale Name is too long")]
        [MinLength(2, ErrorMessage = "The Sale Name is too short")]
        public string? SaleName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string DateShipping { get; set; }

        [Required]
        public string Price { get; set; }
    }
}
