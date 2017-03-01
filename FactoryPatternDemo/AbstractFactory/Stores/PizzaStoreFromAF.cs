using FactoryPatternDemo.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.AbstractFactory.Stores
{
    public abstract class PizzaStoreFromAF
    {
        public PizzaFromAF OrderPizza(string type)
        {
            PizzaFromAF pizza;
            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        // Factor Method
        protected abstract PizzaFromAF CreatePizza(string type);
    }
}
