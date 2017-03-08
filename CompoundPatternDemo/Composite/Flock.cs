using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompoundPatternDemo.Interfaces;
using CompoundPatternDemo.Observer;

namespace CompoundPatternDemo.Composite
{
    public class Flock : IQuackableObservable
    {
        List<IQuackableObservable> quackers = new List<IQuackableObservable>();
        Observable observable;

        public Flock()
        {
            observable = new Observable(this);
        }

        public void Add(IQuackableObservable quacker)
        {
            quackers.Add(quacker);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            foreach (var quack in quackers)
            {
                quack.Quack();
                quack.NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public string GetName()
        {
            return quackers.ToList().ToString();
        }
    }
}
