using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternDemo.Products;

namespace FactoryPatternDemo.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("Cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("Veggie"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("Clam"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("Pepperoni"))
            {
                return new NYStyleCheesePizza();
            }
            return null;
        }
    }
}
