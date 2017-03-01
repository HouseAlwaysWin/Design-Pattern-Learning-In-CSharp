using FactoryPatternDemo.AbstractFactory.Ingredients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.AbstractFactory.Products
{
    public class CheesePizza : PizzaFromAF
    {
        IPizzaIngredientFactory ingredientFactory;
        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
            Pepperoni = ingredientFactory.CreatePepperoni();
            Clam = ingredientFactory.CreateClam();
        }
    }
}
