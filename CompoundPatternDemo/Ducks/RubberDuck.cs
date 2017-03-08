using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompoundPatternDemo.Interfaces;
using CompoundPatternDemo.Observer;

namespace CompoundPatternDemo.Ducks
{
    public class RubberDuck : IQuackableObservable
    {
        Observable observable;
        public RubberDuck()
        {
            observable = new Observable(this);
        }

        public string GetName()
        {
            return "Rubber Duck";
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Squeak");
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }
    }
}
