using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompoundPatternDemo.Interfaces;

using CompoundPatternDemo.Observer;

namespace CompoundPatternDemo.Ducks
{
    public class MallardDuck : IQuackableObservable
    {
        Observable observable;


        public MallardDuck()
        {
            observable = new Observable(this);
        }

        public string GetName()
        {
            return "Mallared Duck";
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }
    }
}
