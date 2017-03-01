using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo.UseIObserable.Provider
{
    public struct WeatherConditionsData
    {
        float temperature;
        float humidity;
        float pressure;

        public WeatherConditionsData(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public float GetTemperature
        {
            get
            {
                return this.temperature;
            }
        }

        public float GetHumidity
        {
            get
            {
                return this.humidity;
            }
        }

        public float GetPressure
        {
            get
            {
                return this.pressure;
            }
        }
    }
}
