using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternDemo.Products;

namespace FactoryPatternDemo.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("Cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("Veggie"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("Clam"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("Pepperoni"))
            {
                return new ChicagoStyleCheesePizza();
            }
            return null;
        }
    }
}
