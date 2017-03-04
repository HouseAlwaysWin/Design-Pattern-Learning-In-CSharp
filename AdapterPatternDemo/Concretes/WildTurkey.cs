using AdapterPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo.Concretes
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble~Gobble!!");
        }
    }
}
