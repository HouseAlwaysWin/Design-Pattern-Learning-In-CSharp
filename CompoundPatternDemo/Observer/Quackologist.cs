using CompoundPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatternDemo.Observer
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine("\nQuackologist: \n" + duck.GetName() + " just quacked.\n");
        }
    }
}
