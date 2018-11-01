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
        

        //constructor


        //member method
        //likeliness to purchase
        //less likely to purchase if too much sugar
        //most likely when recipe balanced
        public override bool DetermineLikelyToPurchase(Player player, Weather weather)
        {
            if ((player.recipe.cupsOfSugarPerPitcher - 1) > player.recipe.lemonsPerPitcher)
            {
                purchaseFactor = .4;
            }
            else if (player.recipe.lemonsPerPitcher == (player.recipe.cupsOfSugarPerPitcher - 1))
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
