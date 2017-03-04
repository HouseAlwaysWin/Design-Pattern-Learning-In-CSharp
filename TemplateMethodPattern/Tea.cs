using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class Tea : CaffeineBeverageBase
    {

        public override void AddCondiments()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void Brew()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Do you wanna Add some condiments?(Y/N)");
            var input = Console.ReadLine();
            if (input == "Y" || input == "y")
            {
                return true;
            }
            return false;
        }
    }
}
