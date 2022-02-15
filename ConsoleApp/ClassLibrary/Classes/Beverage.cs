using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public abstract class Beverage
    {
        protected string Description;

        double milk = 0.50;
        double soy = 0.19;
        double mocha = 2.99;
        double whip = 0.60;

        public string getDescription
        {
            get
            {
                return Description;
            }
        }

        public double Price { get; set; }
        abstract public double Cost();

        public string SetMilk()
        {
            return $"{Description += " + молоко"}: { Price += milk}";
        }

        public string SetSoy()
        {
            return $"{Description += " + соя"}: {Price += soy}";
        }

        public string SetMocha()
        {
            return $"{Description += " + мокко"}: {Price += mocha}";
        }

        public string SetWhip()
        {
            return $"{Description += " + взбитые сливки"}: {Price += whip}";
        }
    }
}