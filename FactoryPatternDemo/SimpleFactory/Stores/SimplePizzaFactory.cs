using FactoryPatternDemo.Products;
using FactoryPatternDemo.SimpleFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.SimpleFactory.Store
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("Cheese"))
            {
                return new CheesePizza();
            }
            else if (type.Equals("Veggie"))
            {
                return new VeggiePizza();
            }
            else if (type.Equals("Clam"))
            {
                return new ClamPizza();
            }
            else if (type.Equals("Pepperoni"))
            {
                return new VeggiePizza();
            }
            return pizza;
        }
    }
}
