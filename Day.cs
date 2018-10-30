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
        Random random = new Random();
        Customer newCustomer;
        private List<Customer> customersPerDay;
        public int day = 0;
        private int numberOfCustomers;
        
        //Customer customer = new List<Customer>();

        public int NewDay()
        {
            weather.GetWeatherForecast();
            if (weather.weatherForecast == weather.beautifulDay)
            {
                numberOfCustomers = 60;
                CreateSunnyDay();
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
            return day++;
        }

        private void CreateSunnyDay()
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {    
                int createCustomer = random.Next(1,5);
                switch (createCustomer)
                {
                    case 1:
                        Customer newCustomer = new Kid();
                        break;
                    case 2:
                        Customer newCustomer = new Mom();
                        break;
                    case 3:
                        Customer newCustomer = new Grandma();
                        break;
                    case 4:
                        Customer newCustomer = new BizMan();
                        break;
                }
                customersPerDay.Add(newCustomer);
            }
        }
    }
}
