using DecoratorPatternDemo.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo.Decorators
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }



        public override string GetDescription
        {
            get
            {
                return beverage.GetDescription + ", Milk";
            }
        }

        public override float Cost()
        {
            return beverage.Cost() + .10f;
        }
    }
}
