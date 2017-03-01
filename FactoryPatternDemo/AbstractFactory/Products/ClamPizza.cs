using FactoryPatternDemo.AbstractFactory.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.AbstractFactory.Products
{
    public class ClamPizza : PizzaFromAF
    {
        IPizzaIngredientFactory ingredientFactory;
        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
            Clam = ingredientFactory.CreateClam();
            Dough = ingredientFactory.CreateDough();
            Pepperoni = ingredientFactory.CreatePepperoni();
        }
    }
}
