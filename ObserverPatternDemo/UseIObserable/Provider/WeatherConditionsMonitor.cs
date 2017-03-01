using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo.UseIObserable.Provider
{
    public class WeatherConditionsMonitor : IObservable<WeatherConditionsData>
    {
        List<IObserver<WeatherConditionsData>> observers;
        List<WeatherConditionsData> weatherDatas;

        bool change;
        public WeatherConditionsMonitor()
        {
            observers = new List<IObserver<WeatherConditionsData>>();
            weatherDatas = new List<WeatherConditionsData>();
        }

        // Register
        public IDisposable Subscribe(IObserver<WeatherConditionsData> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new UnSubscriber(observers, observer);
        }

        public void SetMesurement(WeatherConditionsData data)
        {
            change = true;
            weatherDatas.Add(data);
            NotifyObservsers();
        }

        public void NotifyObservsers()
        {
            System.Threading.Thread.Sleep(1000);


            if (change)
            {
                Console.WriteLine("Start Updating...");
                foreach (var observer in observers)
                {
                    observer.OnNext(weatherDatas.Last());
                    if (observer != null)
                        observer.OnCompleted();
                }
                change = false;
            }

        }



        internal class UnSubscriber : IDisposable
        {
            List<IObserver<WeatherConditionsData>> observers;
            IObserver<WeatherConditionsData> observer;

            // Remove
            public UnSubscriber(List<IObserver<WeatherConditionsData>> observers,
                IObserver<WeatherConditionsData> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }
            public void Dispose()
            {
                if (observer != null)
                {
                    observers.Remove(observer);
                }
            }
        }

    }


}
