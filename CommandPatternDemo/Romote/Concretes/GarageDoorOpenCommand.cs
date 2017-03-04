using CommandPatternDemo.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Romote.Concretes
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor door;
        public GarageDoorOpenCommand(GarageDoor door)
        {
            this.door = door;
        }
        public void Execute()
        {
            door.Up();
        }

        public void Undo()
        {
            door.Stop();
        }
    }
}
