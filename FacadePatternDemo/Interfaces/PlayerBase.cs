using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemo.Interfaces
{

    public abstract class PlayerBase : SwitchBase
    {
        public static readonly int DvdMode = 0;
        public static readonly int CdMode = 1;

        public virtual void Eject()
        {
            Console.WriteLine("Ejecting " + Name);
        }
        public abstract void Play();

        public virtual void Pause()
        {
            Console.WriteLine("Pause " + Name);
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stop " + Name);
        }

    }

}
