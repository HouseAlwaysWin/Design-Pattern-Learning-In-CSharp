using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo.Beverages
{
    public class HouseBlend : Beverage
    {
        protected string GetDescription
        {
            get
            {
                return "House Blend Coffee";
            }
        }

        public override float Cost()
        {
            return 1.99f;
        }


    }
}
