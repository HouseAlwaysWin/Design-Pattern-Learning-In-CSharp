using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Furnitures
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Door is going up");
        }

        public void Down()
        {
            Console.WriteLine("Door is going down");
        }

        public void Stop()
        {
            Console.WriteLine("Door Stopping");
        }

        public void LightOn()
        {
            Console.WriteLine("Light On");
        }

        public void LightOff()
        {
            Console.WriteLine("Light Off");
        }


    }
}
