using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Furnitures
{
    public class Light
    {
        string location;
        public Light(string location)
        {
            this.location = location;
        }
        public void On()
        {
            Console.WriteLine(location + " Light ON");
        }
        public void Off()
        {
            Console.WriteLine(location + " Light OFF");
        }
    }
}
