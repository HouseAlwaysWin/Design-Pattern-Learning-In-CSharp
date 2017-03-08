using StatePatternDemo.StateConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gm = new GumballMachine(10);
            gm.InsertQuarter();
            gm.InsertQuarter();
            gm.TurnCrank();
            Console.WriteLine("Ball left:" + gm.Count);
            gm.InsertQuarter();
            gm.EjectQuarter();
            gm.EjectQuarter();
            gm.InsertQuarter();
            gm.TurnCrank();
            gm.InsertQuarter();
            gm.TurnCrank();
            gm.TurnCrank();
            gm.EjectQuarter();


            Console.WriteLine("Ball left:" + gm.Count);



        }
    }
}
