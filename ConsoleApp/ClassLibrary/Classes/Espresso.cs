using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.Classes
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Эспрессо";
            Price = 1.59;
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
