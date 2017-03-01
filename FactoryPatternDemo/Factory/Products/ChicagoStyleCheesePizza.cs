using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.Products
{
    public class ChicagoStyleCheesePizza : Pizza
    {

        public ChicagoStyleCheesePizza()
        {
            base.Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override string Name
        {
            get
            {
                return "Chicago Style Deep Dish Cheese Pizza";
            }
        }

        protected override string Dough
        {
            get
            {
                return "Extra Thick Crust Dough";
            }
        }

        protected override string Sauce
        {
            get
            {
                return "Plum Tomato  Sauce";
            }
        }



        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }


    }
}
