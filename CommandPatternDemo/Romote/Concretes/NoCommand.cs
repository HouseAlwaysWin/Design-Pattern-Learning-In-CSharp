using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Romote.Concretes
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No Responses");
        }

        public void Undo()
        {
            Console.WriteLine("No Responses");
        }
    }
}
