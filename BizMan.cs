using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class BizMan : Customer
    {
        //member variable
        Store store;

        //constructor


        //member method
        //likeliness to purchase
        //less likely when price is too low
        //more likely to support at higher price
        private void DetermineLikelyToPurchase()
        {
            if (store.price > 1.00)
            {
                likelyToPurchase = (purchaseFactor * .9);
            }
            else if (store.price > .74)
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
