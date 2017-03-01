using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternDemo.AbstractFactory.Products;
using FactoryPatternDemo.AbstractFactory.Ingredients.Interfaces;
using FactoryPatternDemo.AbstractFactory.Ingredients.Contretes;

namespace FactoryPatternDemo.AbstractFactory.Stores
{
    public class NYPizzaStoreFromAF : PizzaStoreFromAF
    {

        protected override PizzaFromAF CreatePizza(string type)
        {
            PizzaFromAF pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "New York Style Clam Pizza";
            }

            return pizza;

        }
    }
}
