using FacadePatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemo.Concrete
{
    public class Projector : SwitchBase
    {
        public void SetInputMode(int mode)
        {
            if (mode == PlayerBase.CdMode)
            {
                Console.WriteLine("Input mode is CD");
            }
            else if (mode == PlayerBase.DvdMode)
            {
                Console.WriteLine("Input mode is DVD");
            }
        }
        public void WideScreedMode()
        {
            Console.WriteLine("Wide Screend Mode is activated");
        }

    }
}
