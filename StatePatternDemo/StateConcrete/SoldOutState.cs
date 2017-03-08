using StatePatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo.StateConcrete
{
    public class SoldOutState : IState
    {
        GumballMachine gm;
        public SoldOutState(GumballMachine gm)
        {
            this.gm = gm;
        }
        public void Dispense()
        {
            Console.WriteLine("There's not more can offer...");
        }

        public void EjectQuater()
        {
            Console.WriteLine("There's not more can offer...");
        }

        public void InsertQuater()
        {
            Console.WriteLine("There's not more can offer...");
        }

        public void TurnCrank()
        {
            Console.WriteLine("There's not more can offer...");
        }
    }
}
