using CommandPatternDemo.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Romote.Concretes
{
    public class CeilingFanCommand : CommandBase
    {
        CeilingFan fan;
        int status;
        int preserved;
        public CeilingFanCommand(CeilingFan fan)
        {
            this.fan = fan;
        }

        public void SetFanStatus(int status)
        {
            this.status = status;
        }
        public override void Execute()
        {
            preserved = fan.GetSpeed;
            if (status == CeilingFan.HIGH)
            {
                fan.High();
            }
            else if (status == CeilingFan.MEDIUM)
            {
                fan.Medium();
            }
            else if (status == CeilingFan.LOW)
            {
                fan.Low();
            }
            else if (status == CeilingFan.OFF)
            {
                fan.Off();
            }
        }

        public override void Undo()
        {
            if (preserved == CeilingFan.HIGH)
            {
                fan.High();
            }
            else if (preserved == CeilingFan.MEDIUM)
            {
                fan.Medium();
            }
            else if (preserved == CeilingFan.LOW)
            {
                fan.Low();
            }
            else if (preserved == CeilingFan.OFF)
            {
                fan.Off();
            }
        }
    }
}
