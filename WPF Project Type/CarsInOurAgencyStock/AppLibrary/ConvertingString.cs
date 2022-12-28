using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary
{
    public static class ConvertingString
    {
        public static CarBrand ToCarBrand(string value)
        {
            CarBrand brand;
            Enum.TryParse<CarBrand>(value, out brand);
            return brand;
        }

        public static CarCondition ToCarCondition(string value)
        {
            CarCondition condition;
            Enum.TryParse<CarCondition>(value, out condition);
            return condition;
        }
    }
}
