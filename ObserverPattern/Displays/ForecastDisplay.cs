using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private readonly Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        { 
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            if (humidity > 50 && temperature > 40)
            {
                Console.WriteLine("Today it is warm " + temperature + " and humid " + humidity + ". Don't go outside");
            }
            else if (temperature < 20)
            {
                Console.WriteLine("Today it is cold " + temperature + ". Wear a thick jacket.");
            }
            else
            {
                Console.WriteLine("Today the weather is comfortable and the current temperature is " + temperature + "and the humidity is " + humidity);
            }
        }
    }
}
