using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DecoratorLibrary.Classes.Additions
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage;
        double milk = 0.20;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return milk + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " + молоко";
        }
    }
}

