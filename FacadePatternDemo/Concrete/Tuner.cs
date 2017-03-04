using FacadePatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemo.Concrete
{
    public class Tuner : SwitchBase
    {
        float frequency;
        void SetAm()
        {
            Console.WriteLine("Activate Am now");
        }

        void SetFm()
        {
            Console.WriteLine("Activate Fm now");
        }

        void SetFrequency(float frequency)
        {
            this.frequency = frequency;
            Console.WriteLine("Frequency is " + frequency.ToString());
        }


    }
}
