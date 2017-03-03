using CommandPatternDemo.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Romote.Concretes
{
    public class LightOffCommand : CommandBase
    {
        Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public override void Execute()
        {
            light.Off();
        }

        public override void Undo()
        {
            light.On();
        }
    }
}
