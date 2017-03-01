using DecoratorPatternDemo.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo.Decorators
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override float Cost()
        {
            return beverage.Cost() + .20f;
        }

        public override string GetDescription
        {
            get
            {
                return beverage.GetDescription + ", Mocha";
            }
        }
    }
}
