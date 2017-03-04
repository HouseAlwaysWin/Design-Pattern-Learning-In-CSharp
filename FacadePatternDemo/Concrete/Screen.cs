using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternDemo.Concrete
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Turn up the Screen");
        }

        public void Down()
        {
            Console.WriteLine("Turn down the Screen");
        }
    }
}
