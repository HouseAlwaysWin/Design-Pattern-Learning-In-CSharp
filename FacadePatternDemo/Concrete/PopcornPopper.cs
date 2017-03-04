using FacadePatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemo.Concrete
{
    public class PopcornPopper : SwitchBase
    {
        public void Pop()
        {
            Console.WriteLine(Name + " Popping popcorn...");
        }
    }
}
