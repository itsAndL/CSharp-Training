using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary.Models
{
    public class SellerModel
    {
        public int SellerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public int SaleID { get; set; }
        public string? SaleName { get; set; }
        public DateTime DateShipping { get; set; }
        public double Price { get; set; }
    }
}
