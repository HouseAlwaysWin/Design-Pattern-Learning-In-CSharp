using DecoratorPatternDemo.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo.Decorators
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override float Cost()
        {
            return beverage.Cost() + .10f;
        }

        public override string GetDescription
        {
            get
            {
                return beverage.GetDescription + ", Whip";
            }
        }
    }
}
