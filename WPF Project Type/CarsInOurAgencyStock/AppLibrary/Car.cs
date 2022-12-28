using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary
{
    public class Car
    {
        public int Year { get; set; }
        public CarBrand Make { get; set; }
        public string Model { get; set; }
        public double Miles { get; set; }
        public int ZIP { get; set; }
        public string ImageSource { get; set; } 
        public Color ExteriorColor { get; set; }
        public Color InteriorColor { get; set; }
        public CarCondition Condition { get; set; }
    }
}
