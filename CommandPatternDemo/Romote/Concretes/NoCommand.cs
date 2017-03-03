using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Romote.Concretes
{
    public class NoCommand : CommandBase
    {
        public override void Execute()
        {
            Console.WriteLine("No Responses");
        }

        public override void Undo()
        {
            Console.WriteLine("No Responses");
        }
    }
}
