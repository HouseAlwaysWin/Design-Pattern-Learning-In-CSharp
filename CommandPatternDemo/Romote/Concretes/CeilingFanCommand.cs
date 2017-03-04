using CommandPatternDemo.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Romote.Concretes
{
    public class CeilingFanCommand : ICommand
    {
        CeilingFan fan;
        int getStatus;
        int preserved;
        public CeilingFanCommand(CeilingFan fan)
        {
            this.fan = fan;
        }

        public void SetFanStatus(int status)
        {
            this.getStatus = status;
        }

        public void Execute()
        {
            preserved = fan.GetSpeed;
            Status(getStatus);
        }

        public void Undo()
        {
            Status(preserved);
        }

        void Status(int status)
        {
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
    }
}
