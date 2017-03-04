using FacadePatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemo.Concrete
{
    public class TheaterLights : SwitchBase
    {
        public void Dim(int scale)
        {
            Console.WriteLine("Turn light dim to " + scale.ToString());
        }
    }
}
