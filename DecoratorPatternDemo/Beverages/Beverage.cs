using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo.Beverages
{

    public abstract class Beverage
    {

        public virtual string GetDescription { get; protected set; }

        public abstract float Cost();

    }
}
