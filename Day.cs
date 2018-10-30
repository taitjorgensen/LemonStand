using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Day
    {
        Weather weather = new Weather();
        //Customer customer = new List<Customer>();

        public void NewDay()
        {
            weather.GetWeatherForecast();
            if (weather.weatherForecast == weather.beautifulDay)
            {
                Customer customer1 = new Kid();
                Customer customer2 = new Mom();
                Customer customer3 = new Grandma();
                Customer customer4 = new BizMan();
            }
            else if (weather.weatherForecast == weather.coolDay)
            {
                Customer customer1 = new Kid();
                Customer customer2 = new Mom();
                Customer customer3 = new BizMan();
            }
            else
            {
                Customer customer1 = new Mom();
                Customer customer2 = new Grandma();
                Customer customer3 = new BizMan();
            }
        }
    }
}
