using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemo.Interfaces
{
    public abstract class SwitchBase
    {

        public virtual string Name { protected get; set; }


        public virtual void On()
        {
            Console.WriteLine("Turn on " + Name);
        }

        public virtual void Off()
        {
            Console.WriteLine("Turn Off " + Name);
        }
    }
}
