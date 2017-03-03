using CommandPatternDemo.Furnitures;
using CommandPatternDemo.Romote;
using CommandPatternDemo.Romote.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Light light = new Light("Living Room");
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);
            RemoteControl control = new RemoteControl();



            control.SetCommand(0, lightOn, lightOff);
            Console.WriteLine(control.ToString());
            control.OnButtonWasPushed(0);
            control.OffButtonWasPushed(0);
            control.UndoButtonWasPushed();


            Console.WriteLine("-------------Fan Control-----------------\n");

            CeilingFan fan = new CeilingFan("My Room");
            CeilingFanCommand fanOff = new CeilingFanCommand(fan);
            CeilingFanCommand fanHigh = new CeilingFanCommand(fan);
            CeilingFanCommand fanMedium = new CeilingFanCommand(fan);
            CeilingFanCommand fanLow = new CeilingFanCommand(fan);
            fanOff.SetFanStatus(CeilingFan.OFF);
            fanHigh.SetFanStatus(CeilingFan.HIGH);
            fanMedium.SetFanStatus(CeilingFan.MEDIUM);
            fanLow.SetFanStatus(CeilingFan.LOW);

            control.SetCommand(1, fanHigh, fanOff);
            control.SetCommand(2, fanMedium, fanOff);
            control.SetCommand(3, fanLow, fanOff);

            control.OnButtonWasPushed(1);
            control.OnButtonWasPushed(2);
            control.OnButtonWasPushed(3);
            control.UndoButtonWasPushed();
            control.OffButtonWasPushed(2);

            Console.WriteLine(control.ToString());
        }
    }
}
