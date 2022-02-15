using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.Classes
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Кофе тёмной обжарки";
            Price = 1.99;
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