using StatePatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo.StateConcrete
{
    public class NoQuarterState : IState
    {
        GumballMachine gm;
        public NoQuarterState(GumballMachine gm)
        {
            this.gm = gm;
        }
        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuater()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void InsertQuater()
        {
            Console.WriteLine("You inserted a quarter");
            gm.State = gm.HasQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned , but there's no quarter");
        }
    }
}
