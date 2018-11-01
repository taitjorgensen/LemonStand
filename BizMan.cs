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

        private double purchaseFactor;
        //constructor


        //member method
        //less likely when price is too low
        //more likely to support at higher price

        public override bool DetermineLikelyToPurchase(Player player, Weather weather)
        {
            if (player.price > 1.00)
            {
                purchaseFactor = .9;
            }
            else if (player.price > .74)
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
