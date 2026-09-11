using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private readonly Subject weatherData;
        public StatisticsDisplay(Subject weatherData) 
        { 
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            sumTemperature += temperature;

            countUpdated++;

            if (countUpdated == 1)
            {
                maxTemp = temperature;
                minTemp = temperature;
            }
            else
            {
                if (temperature > maxTemp)
                {
                    maxTemp = temperature;
                }
                if (temperature < minTemp)
                {
                    minTemp = temperature;
                }
            }
                Display();
        }

        public void Display()
        {
            float average = sumTemperature / countUpdated;
            Console.WriteLine("The average temperature is " + average + " and the maximum temperature is " + maxTemp + ". the minimal temperature is: " + minTemp);
        }
    }
}
