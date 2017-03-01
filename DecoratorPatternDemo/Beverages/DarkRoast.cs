using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo.Beverages
{
    public class DarkRoast : Beverage
    {
        public override string GetDescription
        {
            get
            {
                return "Espresso";
            }
        }




        public override float Cost()
        {

            return 1.99f;
        }


    }
}
