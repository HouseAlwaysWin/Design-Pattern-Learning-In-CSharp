using CommandPatternDemo.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Romote.Concretes
{
    public class GarageDoorOpenCommand : CommandBase
    {
        GarageDoor door;
        public GarageDoorOpenCommand(GarageDoor door)
        {
            this.door = door;
        }
        public override void Execute()
        {
            door.Up();
        }

        public override void Undo()
        {
            door.Stop();
        }
    }
}
