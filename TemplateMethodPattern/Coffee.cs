using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern;

namespace TemplateMethodPattern
{
    public class Coffee : CaffeineBeverageBase
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Add Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}
