using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLibrary;
using DecoratorLibrary.Classes;

namespace DecoratorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseBlend houseBlend = new HouseBlend();
            Espresso espresso = new Espresso();
            Decaf decaf = new Decaf();
            DarkRoast darkRoast = new DarkRoast();

            Console.WriteLine(darkRoast.getDescription + ": " + darkRoast.Cost());
            Console.WriteLine(darkRoast.SetMilk());
            Console.WriteLine(darkRoast.SetSoy());
            Console.WriteLine();

            Console.WriteLine(decaf.getDescription + ": " + decaf.Cost());
            Console.WriteLine(decaf.SetSoy());
            Console.WriteLine();

            Console.WriteLine(espresso.getDescription + ": " + espresso.Cost());
            Console.WriteLine(espresso.SetMocha());
            Console.WriteLine(espresso.SetWhip());
            Console.WriteLine();

            Console.WriteLine(houseBlend.getDescription + ": " + houseBlend.Cost());
            Console.WriteLine(houseBlend.SetSoy());
            Console.WriteLine(houseBlend.SetWhip());

            Console.ReadKey();
        }
    }
}
