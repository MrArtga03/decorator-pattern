using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.Classes.Additions
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        double mocha = 0.50;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return mocha + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " + шоколад";
        }
    }
}

