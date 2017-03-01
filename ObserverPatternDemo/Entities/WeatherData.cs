using ObserverPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo.Entities
{
    public class WeatherData : ISubject
    {
        List<IObserver> observers;
        float tempersture;
        float humidity;
        float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach (var obs in observers)
            {
                obs.Update(tempersture, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void MessurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMessurements(float temperature, float humidity, float pressure)
        {
            this.tempersture = tempersture;
            this.humidity = humidity;
            this.pressure = pressure;
            MessurementsChanged();
        }
    }
}
