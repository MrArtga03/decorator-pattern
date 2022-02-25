using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLibrary;
using DecoratorLibrary.Classes;
using DecoratorLibrary.Classes.Additions;

namespace DecoratorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage houseBlend = new HouseBlend();
            Beverage espresso = new Espresso();
            Beverage decaf = new Decaf();
            Beverage darkRoast = new DarkRoast();

            Console.WriteLine($"Кофе: {houseBlend.GetDescription()} - Стоимость: {houseBlend.Cost()}$");
            Console.WriteLine($"Кофе: {espresso.GetDescription()} - Стоимость: {espresso.Cost()}$");
            Console.WriteLine($"Кофе: {decaf.GetDescription()} - Стоимость: {decaf.Cost()}$");
            Console.WriteLine($"Кофе: {darkRoast.GetDescription()} - Стоимость: {darkRoast.Cost()}$");

            Console.WriteLine("------");

            houseBlend = new Milk(houseBlend);
            houseBlend = new Whip(houseBlend);
            Console.WriteLine($"Кофе: {houseBlend.GetDescription()} - Стоимость: {houseBlend.Cost()}$");

            Console.WriteLine("------");

            decaf = new Mocha(decaf);
            Console.WriteLine($"Кофе: {decaf.GetDescription()} - Стоимость: {decaf.Cost()}$");

            Console.WriteLine("------");

            espresso = new Mocha(espresso);
            espresso = new Soy(espresso);
            Console.WriteLine($"Кофе: {espresso.GetDescription()} - Стоимость: {espresso.Cost()}$");

            Console.WriteLine("------");

            darkRoast = new Mocha(darkRoast);
            darkRoast = new Soy(darkRoast);
            darkRoast = new Milk(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine($"Кофе: {darkRoast.GetDescription()} - Стоимость: {darkRoast.Cost()}$");

            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
