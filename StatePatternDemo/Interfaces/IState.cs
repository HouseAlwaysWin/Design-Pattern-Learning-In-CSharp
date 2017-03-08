using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo.Interfaces
{
    public interface IState
    {
        void InsertQuater();
        void EjectQuater();
        void TurnCrank();
        void Dispense();
    }
}
