using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompoundPatternDemo.Interfaces;
using CompoundPatternDemo.Observer;

namespace CompoundPatternDemo.Ducks
{
    public class DuckCall : IQuackableObservable
    {
        Observable observable;
        public DuckCall()
        {
            observable = new Observable(this);
        }

        public string GetName()
        {
            return "DuckCall";
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Kwak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }
    }
}
