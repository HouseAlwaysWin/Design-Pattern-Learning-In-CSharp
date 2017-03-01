using ObserverPatternDemo.UseIObserable.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo.UseIObserable.Subscriber
{
    public class DisplayAllConditions : IObserver<WeatherConditionsData>
    {
        IDisposable unSubscriber;
        public virtual void Subscribed(IObservable<WeatherConditionsData> weatherData)
        {
            unSubscriber = weatherData.Subscribe(this);
        }

        public virtual void UnSubscribed()
        {
            unSubscriber.Dispose();
        }


        public void OnCompleted()
        {
            Console.WriteLine("Finish Updated Display All");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Something wrong");
        }

        public void OnNext(WeatherConditionsData value)
        {
            Console.WriteLine("Current Temperature: {0}, Humidity: {1}, Pressure: {2}",
                value.GetTemperature, value.GetHumidity, value.GetPressure);
        }
    }
}
