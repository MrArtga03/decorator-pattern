using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public abstract class Beverage
    {
        protected string Description = "Unknown Beverage";

        abstract public string GetDescription();

        public double Price { get; set; }
        abstract public double Cost();
    }
}