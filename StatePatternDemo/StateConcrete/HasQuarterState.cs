using StatePatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo.StateConcrete
{
    public class HasQuarterState : IState
    {

        GumballMachine gm;
        public HasQuarterState(GumballMachine gm)
        {
            this.gm = gm;
        }



        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuater()
        {
            Console.WriteLine("Quarter returned");
            gm.State = gm.NoQuarterState;
        }

        public void InsertQuater()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            gm.State = gm.SoldState;
        }
    }
}
