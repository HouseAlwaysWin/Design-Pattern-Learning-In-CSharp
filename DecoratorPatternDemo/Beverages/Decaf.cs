using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo.Beverages
{
    public class Decaf : Beverage
    {
        public override string GetDescription
        {
            get
            {
                return "Decaf";
            }
        }
        public override float Cost()
        {
            return 1.05f;
        }
    }
}
