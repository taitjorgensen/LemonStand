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
        public int dayNumber = 0;
        private int numberOfCustomers;
        public int lemonadeSold = 0;
        Customer newCustomer;

        //Customer customer = new List<Customer>();

        public int NewDay(Player player)
        {
            weather.GetWeatherForecast();
            if (weather.weatherForecast == weather.beautifulDay)
            {
                numberOfCustomers = 60;
                CreateSunnyDay(player);
            }
            else if (weather.weatherForecast == weather.coolDay)
            {
                numberOfCustomers = 50;
                CreateCoolDay(player);
            }
            else
            {
                numberOfCustomers = 35;
                CreateRainyDay(player);
            }
            SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
            return dayNumber++;
            
        }

        public void CreateSunnyDay(Player player)
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {              
                int createCustomer = random.Next(1,5);
                switch (createCustomer)
                {
                    case 1:                        
                        newCustomer = new Kid();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                    case 2:
                        newCustomer = new Mom();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                    case 3:
                        newCustomer = new Grandma();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                    case 4:
                        newCustomer = new BizMan();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                    default:
                        newCustomer = new Mom();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                }
                customersPerDay.Add(newCustomer);
            }
        }
        public void CreateCoolDay(Player player)
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {
                int createCustomer = random.Next(1, 5);
                switch (createCustomer)
                {
                    case 1:
                        newCustomer = new Kid();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                    case 2:
                        newCustomer = new Mom();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                    case 3:
                        newCustomer = new Grandma();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                    case 4:
                        newCustomer = new BizMan();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                    default:
                        newCustomer = new Mom();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                }
                customersPerDay.Add(newCustomer);
            }
        }
        public void CreateRainyDay(Player player)
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {
                int createCustomer = random.Next(1, 5);
                switch (createCustomer)
                {
                    case 1:
                        newCustomer = new Kid();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                    case 2:
                        newCustomer = new Mom();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                    case 3:
                        newCustomer = new Grandma();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                    case 4:
                        newCustomer = new BizMan();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                    default:
                        newCustomer = new Mom();
                        SellLemonade(player, newCustomer.DetermineLikelyToPurchase(player, weather));
                        break;
                }
                customersPerDay.Add(newCustomer);
            }
        }
        public int SellLemonade(Player player, bool didPurchase)
        {          
            if (didPurchase)
            {
                player.pitchers[player.pitchers.Count - 1].CurrentAvailableLemonade();
                player.inventory.Cups = player.inventory.Cups - 1;
                player.currentFunds = player.currentFunds + player.price;
                return lemonadeSold++;
            }
            return lemonadeSold;
        }
    }
}
