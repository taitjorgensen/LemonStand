using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Weather
    {
        //member variable
        public string weatherForecast;
        public string beautifulDay = "Sunny and warm";
        public string rainyDay = "Rain expected throughout the day";
        public string coolDay = "Cooler tempuratures today";

        //constructor


        //member method
        public string GetWeatherForecast()
        {
            Random random = new Random();
            int dailyWeather = random.Next(0, 4);
            if (dailyWeather == 0)
            {
                Console.WriteLine(coolDay);
                Console.ReadLine();
            }
            else if (dailyWeather == 1)
            {
                Console.WriteLine(rainyDay);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(beautifulDay);
                Console.ReadLine();
            }
            return weatherForecast;
        }

    }
}
