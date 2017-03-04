using FacadePatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemo.Concrete
{
    public class DvdPlayer : PlayerBase
    {
        public override void Play()
        {
            Console.WriteLine("Playing DVD... " + Name);
        }
    }
}
