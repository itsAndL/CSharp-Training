using System.ComponentModel.DataAnnotations;

namespace TechCompaniesUI.Models
{
    public class DisplayCompanyModel
    {
        [Required]
        [StringLength(15)]
        [MinLength(3)]
        public string? CompanyName { get; set; }

        [Required]
        [MinLength(25)]
        public string? Description { get; set; }

        [Required]
        public string? Headquarters { get; set; }

        [Required]
        public string? Founders { get; set; }

        [Required]
        public string? Founded { get; set; }

        [Required]
        [Url]
        public string? Url { get; set; }

        [Required]
        [Url]
        public string? ImageSource { get; set; }
    }
}
