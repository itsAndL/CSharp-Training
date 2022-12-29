using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyAndSellACarLibrary.Models
{
    public class Car
    {
        public string? Condition { get; set; }
        public string? Year { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Mileage { get; set; }
        public string? Price { get; set; }
        public string? FuelType { get; set; }
        public string? ImageSource { get; set; }
        public Seller? SellerInfo { get; set; }
    }
}
