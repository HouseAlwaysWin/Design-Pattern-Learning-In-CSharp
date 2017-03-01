using ObserverPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo.Entities
{
    public class CurrenContionsDisplay : IDisplayElement, IObserver
    {
        float temperature;
        float humidity;
        ISubject weatherData;

        public CurrenContionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: {0} F degrees and {1}% humidity",
                this.temperature, this.humidity);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }
    }
}
