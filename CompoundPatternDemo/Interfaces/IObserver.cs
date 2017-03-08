using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatternDemo.Interfaces
{
    public interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}
