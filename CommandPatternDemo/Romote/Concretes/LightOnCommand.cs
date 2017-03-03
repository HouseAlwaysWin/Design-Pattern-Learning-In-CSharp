﻿using CommandPatternDemo.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Romote.Concretes
{
    public class LightOnCommand : CommandBase
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public override void Execute()
        {
            light.On();
        }

        public override void Undo()
        {
            light.Off();
        }
    }
}