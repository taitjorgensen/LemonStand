using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Day
    {
        public Weather weather = new Weather();
        Random random = new Random();
        private List<Customer> customersPerDay = new List<Customer> { };
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
                numberOfCustomers = 40;
                CreateCoolDay();
            }
            else
            {
                numberOfCustomers = 20;
                CreateRainyDay();
            }
            SellLemonade();
            return day++;
            
        }

        public void CreateSunnyDay()
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer newCustomer;
                int createCustomer = random.Next(1,5);
                switch (createCustomer)
                {
                    case 1:                        
                        newCustomer = new Kid();
                        //kid.GetPurchaseFactor(weather.weatherForecast, pitcher.price);
                        break;
                    case 2:
                        newCustomer = new Mom();
                        //mom.GetPurchaseFactor(recipe.recipeBalance);
                        break;
                    case 3:
                        newCustomer = new Grandma();
                        //grandma.GetPurchaseFactor(weather.weatherForecast);
                        break;
                    case 4:
                        newCustomer = new BizMan();
                        //bizMan.DetermineLikelyToPurchase(pitcher.price);
                        break;
                    default:
                        newCustomer = new Mom();
                        //mom.GetPurchaseFactor(recipe.recipeBalance);
                        break;
                }
                customersPerDay.Add(newCustomer);
            }
        }
        public void CreateCoolDay()
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer newCustomer;
                int createCustomer = random.Next(1, 5);
                switch (createCustomer)
                {
                    case 1:
                        newCustomer = new Kid();
                        //kid.GetPurchaseFactor(weather.weatherForecast, pitcher.price);
                        break;
                    case 2:
                        newCustomer = new Mom();
                        //mom.GetPurchaseFactor(recipe.recipeBalance);
                        break;
                    case 3:
                        newCustomer = new Grandma();
                        //grandma.GetPurchaseFactor(weather.weatherForecast);
                        break;
                    case 4:
                        newCustomer = new BizMan();
                        //bizMan.GetPurchaseFactor(pitcher.price);
                        break;
                    default:
                        newCustomer = new Mom();
                        //mom.GetPurchaseFactor(recipe.recipeBalance);
                        break;
                }
                customersPerDay.Add(newCustomer);
            }
        }
        public void CreateRainyDay()
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer newCustomer;
                int createCustomer = random.Next(1, 5);
                switch (createCustomer)
                {
                    case 1:
                        newCustomer = new Kid();
                        //kid.GetPurchaseFactor(weather.weatherForecast, pitcher.price);
                        break;
                    case 2:
                        newCustomer = new Mom();
                        //mom.GetPurchaseFactor(recipe.recipeBalance);
                        break;
                    case 3:
                        newCustomer = new Grandma();
                        //grandma.GetPurchaseFactor(weather.weatherForecast);
                        break;
                    case 4:
                        newCustomer = new BizMan();
                        //bizMan.GetPurchaseFactor(pitcher.price);
                        break;
                    default:
                        newCustomer = new Mom();
                        //mom.GetPurchaseFactor(recipe.recipeBalance);
                        break;
                }
                customersPerDay.Add(newCustomer);
            }
        }
        private void SellLemonade()
        {

        }
    }
}
