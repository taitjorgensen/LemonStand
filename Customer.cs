using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Customer
    {
        //member variables
        //customer types - child classes??
        protected string factors;
        protected double likelyToPurchase;

        //constructor


        //member methods
        //likeliness to purchase
        public void DetermineLikelyToPurchase()
        {

        }

        protected void LikelyToPurchase(string[] factors)
        {
            string[,] purchaseFactors = { { "low", "med", "high" }, { "sweet", "sour", "balanced" }, { "sunny", "rainy", "cool" } };

        }
    }
}
