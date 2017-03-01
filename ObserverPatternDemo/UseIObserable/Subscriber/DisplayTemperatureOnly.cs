using ObserverPatternDemo.UseIObserable.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo.UseIObserable.Subscriber
{
    public class DisplayTemperatureOnly : IObserver<WeatherConditionsData>
    {

        IDisposable unSubscriber;

        public void Subscribe(IObservable<WeatherConditionsData> weatherData)
        {
            unSubscriber = weatherData.Subscribe(this);
        }

        public void UnSubscribe()
        {
            unSubscriber.Dispose();
        }

        public void OnCompleted()
        {
            Console.WriteLine("Finish Updated TemperatureOnly");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Somthing Wrong");
        }

        public void OnNext(WeatherConditionsData value)
        {
            Console.WriteLine("Temperature: {0} ", value.GetTemperature);
        }
    }
}
