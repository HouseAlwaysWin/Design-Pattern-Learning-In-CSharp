using FactoryPatternDemo.Products;
using FactoryPatternDemo.SimpleFactory.Store;
using FactoryPatternDemo.SimpleFactory.Stores;
using FactoryPatternDemo.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{

    class Program
    {

        static void Main(string[] args)
        {
            PizzaStore NYStore = new NYPizzaStore();
            Pizza pizza = NYStore.OrderPizza("Cheese");
            Console.WriteLine("Ethan order a " + pizza.Name + "\n");

            Console.WriteLine("---------------------------------------------------\n");

            PizzaStore ChicargoStore = new ChicagoPizzaStore();
            pizza = ChicargoStore.OrderPizza("Clam");
            Console.WriteLine("Joel ordered a " + pizza.Name + "\n");


            Console.WriteLine("-----------------------------------\n");

            SimplePizzaFactory simpleFactory = new SimplePizzaFactory();

            SimplePizzaStore simpleStore = new SimplePizzaStore(simpleFactory);

            pizza = simpleStore.OrderPizza("Cheese");


            Console.WriteLine("Martin ordered a " + pizza.Name + "\n");


        }
    }
}
