using CompoundPatternDemo.Gooses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompoundPatternDemo.Interfaces;
using CompoundPatternDemo.Observer;

namespace CompoundPatternDemo.Adapter
{
    public class GooseAdapter : IQuackableObservable
    {
        Goose goose = new Goose();
        Observable observable;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
            observable = new Observable(this);
        }

        public string GetName()
        {
            return "Goose";
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            goose.Honk();
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }
    }
}
