using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Grandma : Customer
    {
        //member variable

        //constructor


        //member method
        //likeliness to purchase
        //less likely to purchase when too cold
        //most likely when warm
        public override bool DetermineLikelyToPurchase(Player player, Weather weather)
        {
            if ((weather.weatherForecast == weather.beautifulDay) && (player.price < 1.00))
            {
                purchaseFactor = .95;
            }
            else if (weather.weatherForecast == weather.beautifulDay)
            {
                purchaseFactor = .75;
            }
            else if ((weather.weatherForecast == weather.rainyDay) || (player.price >= 1.00))
            {
                purchaseFactor = .7;
            }
            else
            {
                purchaseFactor = .5;
            }
            return PurchasesLemonade();
        }
        public bool PurchasesLemonade()
        {
            Random random = new Random();
            if (random.Next(1, 101) > (purchaseFactor * 100))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
