using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompoundPatternDemo.Interfaces;
using CompoundPatternDemo.Observer;

namespace CompoundPatternDemo.Decorator
{
    public class QuackCounter : IQuackableObservable
    {
        IQuackableObservable duck;
        Observable observable;

        public static int quackCount { get; private set; }
        public QuackCounter(IQuackableObservable duck)
        {
            this.duck = duck;
            observable = new Observable(this);
        }
        public void Quack()
        {
            duck.Quack();
            quackCount++;
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public string GetName()
        {
            return duck.GetName();
        }
    }
}
