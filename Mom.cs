using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Mom : Customer
    {
        //member variables
        Store store;

        //constructor


        //member method
        //likeliness to purchase
        //less likely to purchase if too much sugar
        //most likely when recipe balanced
        private void DetermineLikelyToPurchase()
        {
            if (store.cupsOfSugarPerPitcher > store.lemonsPerPitcher)
            {
                likelyToPurchase = (purchaseFactor * .4);
            }
            else if (store.lemonsPerPitcher == store.cupsOfSugarPerPitcher)
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
