using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.Classes.Additions
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        double whip = 0.10;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return whip + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " + взбитые сливки";
        }
    }
}
