using DecoratorPatternDemo.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        public override string GetDescription
        {
            get
            {
                return base.GetDescription;
            }

            protected set
            {
                base.GetDescription = value;
            }
        }

    }
}
