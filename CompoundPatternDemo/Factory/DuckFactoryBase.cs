using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatternDemo.Factory
{
    public abstract class DuckFactoryBase
    {
        public abstract IQuackableObservable CreateMallardDuck();
        public abstract IQuackableObservable CreateRedheadDuck();
        public abstract IQuackableObservable CreateRubberDuck();
        public abstract IQuackableObservable CreateDuckCall();
    }
}
