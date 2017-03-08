using CompoundPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPatternDemo.Observer
{
    public class Observable : IQuackObservable
    {
        List<IObserver> observers = new List<IObserver>();

        IQuackObservable duck;

        public Observable(IQuackObservable duck)
        {
            this.duck = duck;
        }


        public void NotifyObservers()
        {
            foreach (var ob in observers)
            {
                ob.Update(duck);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public string GetName()
        {
            return duck.GetName();
        }
    }
}
