using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.Classes
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Кофе без кофеина";
            Price = 1.00;
        }

        public override double Cost()
        {
            return Price;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
