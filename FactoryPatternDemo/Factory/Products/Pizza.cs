using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.Products
{
    public abstract class Pizza
    {
        public abstract string Name { get; }
        protected abstract string Dough { get; }
        protected abstract string Sauce { get; }

        protected List<string> Toppings;


        protected Pizza()
        {
            Toppings = new List<string>();
        }


        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + Name + "...");
            Console.WriteLine("Tossing " + Dough + "...");
            Console.WriteLine("Adding Sauce " + Sauce + "...");
            Console.WriteLine("Adding Toppings: ");
            foreach (var tops in Toppings)
            {
                Console.WriteLine("   " + tops);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minuates at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }






    }
}
