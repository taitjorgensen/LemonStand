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
        Weather weather;

        //constructor


        //member method
        //likeliness to purchase
        //less likely to purchase when too cold
        //most likely when warm
        private void DetermineLikelyToPurchase()
        {
            if (weather.weatherForecast == weather.beautifulDay)
            {
                likelyToPurchase = (purchaseFactor * .9);
            }
            else if (weather.weatherForecast == weather.rainyDay)
            {
                likelyToPurchase = (purchaseFactor * .7);
            }
            else
            {
                likelyToPurchase = (purchaseFactor * .4);
            }
        }
    }
}
