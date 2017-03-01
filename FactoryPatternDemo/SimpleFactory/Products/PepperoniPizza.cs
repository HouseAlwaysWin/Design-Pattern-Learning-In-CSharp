using FactoryPatternDemo.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.SimpleFactory.Products
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            base.Toppings.Add("Shredded Mozzarella Cheese");
        }
        public override string Name
        {
            get
            {
                return "PepperoniPizza";
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
