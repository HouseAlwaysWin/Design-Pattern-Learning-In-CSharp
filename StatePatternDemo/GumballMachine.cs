using StatePatternDemo.Interfaces;
using StatePatternDemo.StateConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    public class GumballMachine
    {
        public IState SoldOutState { get; private set; }
        public IState NoQuarterState { get; private set; }
        public IState HasQuarterState { get; private set; }
        public IState SoldState { get; private set; }
        public IState WinnerState { get; private set; }
        public IState State { get; set; }
        public int Count { get; set; }

        public GumballMachine(int numberGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);

            State = SoldOutState;

            this.Count = numberGumballs;
            if (numberGumballs > 0)
            {
                State = NoQuarterState;
            }
        }

        public void InsertQuarter()
        {
            State.InsertQuater();

        }

        public void EjectQuarter()
        {
            State.EjectQuater();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        internal void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rollng out the slot...");
            if (Count != 0)
            {
                Count--;
            }
        }


    }
}
