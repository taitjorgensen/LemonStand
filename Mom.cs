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
        Recipe recipe;

        //constructor


        //member method
        //likeliness to purchase
        //less likely to purchase if too much sugar
        //most likely when recipe balanced
        private void DetermineLikelyToPurchase()
        {
            if ((recipe.cupsOfSugarPerPitcher - 1) > recipe.lemonsPerPitcher)
            {
                likelyToPurchase = (purchaseFactor * .4);
            }
            else if (recipe.lemonsPerPitcher == (recipe.cupsOfSugarPerPitcher - 1))
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
