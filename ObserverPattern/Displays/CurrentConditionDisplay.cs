using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private readonly Subject weatherData;
        public CurrentConditionDisplay(Subject weatherData) 
        { 
          this.weatherData = weatherData;
          weatherData.RegisterObserver(this);
            // Set the field and register itself with the weatherdata subject
        }
        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;

            // Set the correct fields with the relevant parameters
            Display();
        }

        public void Display()
        {
            Console.WriteLine("The current weather is: " + temperature + " degrees and the humidity is " + humidity + "%");
        }
    }
}
