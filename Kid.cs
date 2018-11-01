using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Kid : Customer 
    {
        //member variable
        private double purchaseFactor;

        //constructor


        //member method
        //likeliness to purchase
        //less likely to purchase when raining or too expensive
        //most likely when sunny and lower price
        public override bool DetermineLikelyToPurchase(Player player, Weather weather)
        {
            if (player.price > 1.00 || weather.weatherForecast == weather.rainyDay)
            {
                purchaseFactor = .4;
            }
            else if (player.price > .74 || weather.weatherForecast == weather.coolDay)
            {
                purchaseFactor = .7;
            }
            else
            {
                purchaseFactor = .9;
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
