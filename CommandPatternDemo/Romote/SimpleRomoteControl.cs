using CommandPatternDemo.Romote;
using CommandPatternDemo.Romote.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Romote
{
    public class SimpleRomoteControl
    {
        CommandBase slot;

        public SimpleRomoteControl()
        {

        }

        public void SetCommand(CommandBase command)
        {
            this.slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
