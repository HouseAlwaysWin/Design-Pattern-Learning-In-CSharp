using CompoundPatternDemo.Decorator;
using CompoundPatternDemo.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatternDemo.Factory
{
    public class DuckFactory : DuckFactoryBase
    {
        public override IQuackableObservable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackableObservable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackableObservable CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuackableObservable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
