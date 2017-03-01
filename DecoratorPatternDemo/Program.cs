using DecoratorPatternDemo.Beverages;
using DecoratorPatternDemo.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new DarkRoast();
            beverage1 = new Milk(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine("Total Price: {0}, Description: {1}",
                beverage1.Cost(), beverage1.GetDescription);
        }
    }
}
