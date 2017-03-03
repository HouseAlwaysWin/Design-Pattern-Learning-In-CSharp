using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Romote.Concretes
{
    public abstract class CommandBase
    {
        public abstract void Execute();


        public abstract void Undo();

    }
}

