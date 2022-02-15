using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.Classes
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "Хаусбленд";
            Price = 2.99;
        }

        public override double Cost()
        {
            return Price;
        }
    }
}
