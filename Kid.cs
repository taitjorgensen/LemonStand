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
        Store store;
        Weather weather;

        //constructor


        //member method
        //likeliness to purchase
        //less likely to purchase when raining or too expensive
        //most likely when sunny and lower price
        private void DetermineLikelyToPurchase()
        {
            if (store.price > 1.00 || weather.weatherForecast == weather.rainyDay)
            {
                likelyToPurchase = (purchaseFactor * .4);
            }
            else if (store.price > .74 || weather.weatherForecast == weather.coolDay)
            {
                likelyToPurchase = (purchaseFactor * .7);
            }
            else
            {
                likelyToPurchase = (purchaseFactor * .9);
            }
        }
    }
}
