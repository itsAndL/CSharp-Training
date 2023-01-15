using System.ComponentModel.DataAnnotations;

namespace SalesUI.Models
{
    public class DisplayUDSalesModel
    {
        [Required]
        public string SellerId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Sale Name is too long")]
        [MinLength(2, ErrorMessage = "The Sale Name is too short")]
        public string? NewSaleName { get; set; }
    }
}
