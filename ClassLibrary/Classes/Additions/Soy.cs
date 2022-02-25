using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.Classes.Additions
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        double soy = 0.10;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return soy + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " + соя";
        }
    }
}
