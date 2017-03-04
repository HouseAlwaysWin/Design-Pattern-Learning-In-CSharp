using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Furnitures
{
    public class CeilingFan
    {
        public static readonly int HIGH = 0;
        public static readonly int MEDIUM = 1;
        public static readonly int LOW = 2;
        public static readonly int OFF = 3;
        public int GetSpeed { get; private set; }

        string location;
        public CeilingFan(string location)
        {
            this.location = location;
        }

        public void High()
        {
            GetSpeed = HIGH;
            Console.WriteLine(location + "'s Fan is in High speed");
        }

        public void Medium()
        {
            GetSpeed = MEDIUM;
            Console.WriteLine(location + "'s Fan is in Medium speed");
        }

        public void Low()
        {
            GetSpeed = LOW;
            Console.WriteLine(location + "'s Fan is in Low speed");
        }

        public void Off()
        {
            GetSpeed = OFF;
            Console.WriteLine(location + "'s Fan is in Off now");
        }


    }
}
