using CompoundPatternDemo.Adapter;
using CompoundPatternDemo.Composite;
using CompoundPatternDemo.Decorator;
using CompoundPatternDemo.Ducks;
using CompoundPatternDemo.Factory;
using CompoundPatternDemo.Gooses;
using CompoundPatternDemo.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatternDemo
{
    public class DuckSumulator
    {
        DuckFactoryBase factory;
        public DuckSumulator(DuckFactoryBase factory)
        {
            this.factory = factory;
        }
        public void Simulate()
        {
            IQuackableObservable mallardDuck = factory.CreateMallardDuck();
            IQuackableObservable redheadDuck = factory.CreateRubberDuck();
            IQuackableObservable duckCall = factory.CreateDuckCall();
            IQuackableObservable rubberDuck = factory.CreateRubberDuck();
            IQuackableObservable gooseDuck = new GooseAdapter(new Goose());


            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(mallardDuck);
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);

            Quackologist q = new Quackologist();

            flockOfDucks.RegisterObserver(q);
            mallardDuck.RegisterObserver(q);



            Console.WriteLine("-----Whole Ducks quack-----\n");

            Simulate(flockOfDucks);






            Console.WriteLine("--------Duck Simulator----------");

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            Console.WriteLine("Quacks Count:" + QuackCounter.quackCount);


        }

        void Simulate(IQuackableObservable duck)
        {
            duck.Quack();
        }
    }
}
