using ObserverPatternDemo.Entities;
using ObserverPatternDemo.UseIObserable.Provider;
using ObserverPatternDemo.UseIObserable.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //WeatherData weatherData = new WeatherData();
            //CurrenContionsDisplay currentContion = new CurrenContionsDisplay(weatherData);

            //weatherData.SetMessurements(80, 65, 30.4f);






            WeatherConditionsMonitor weatherData = new WeatherConditionsMonitor();
            DisplayAllConditions displayAll = new DisplayAllConditions();

            Console.WriteLine("Show all conditions:");
            displayAll.Subscribed(weatherData);

            weatherData.SetMesurement(new WeatherConditionsData(80, 65, 30.4f));
            weatherData.SetMesurement(new WeatherConditionsData(82, 70, 29.4f));
            weatherData.SetMesurement(new WeatherConditionsData(90, 60, 28.4f));

            DisplayTemperatureOnly displayTemp = new DisplayTemperatureOnly();

            Console.WriteLine("Show Tempature Start Subscribe ");

            displayTemp.Subscribe(weatherData);


            weatherData.SetMesurement(new WeatherConditionsData(11, 22, 33));
            displayTemp.UnSubscribe();
            weatherData.SetMesurement(new WeatherConditionsData(1, 2, 3));




        }
    }
}
