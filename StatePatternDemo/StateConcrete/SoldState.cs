using StatePatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo.StateConcrete
{
    public class SoldState : IState
    {
        GumballMachine gm;

        public SoldState(GumballMachine gm)
        {
            this.gm = gm;
        }
        public void Dispense()
        {
            gm.ReleaseBall();
            if (gm.Count > 0)
            {
                gm.State = gm.NoQuarterState;
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gm.State = gm.SoldOutState;
            }
        }

        public void EjectQuater()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuater()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Doesn't response...");
        }
    }
}
