using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.Products
{
    public class NYStyleCheesePizza : Pizza
    {

        public NYStyleCheesePizza()
        {
            base.Toppings.Add("Grated Reggiano Cheese");
        }

        public override string Name
        {
            get
            {
                return "NY Style Sauce and Cheese Pizza";
            }
        }

        protected override string Dough
        {
            get
            {
                return "Thin Crust Dough";
            }
        }

        protected override string Sauce
        {
            get
            {
                return "Marinara Sauce";
            }
        }


    }
}
