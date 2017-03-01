using FactoryPatternDemo.AbstractFactory.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.AbstractFactory.Products
{
    public abstract class PizzaFromAF
    {

        public string Name { get; set; }

        // Start Implement in Child class, Factory Method
        protected IDough Dough;
        protected ISauce Sauce;
        protected ICheese Cheese;
        protected IPepperoni Pepperoni;
        protected IClams Clam;
        public abstract void Prepare();
        // End Implement


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
