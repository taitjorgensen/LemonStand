using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    abstract class Customer
    {
        //member variables
        //customer types - child classes??
        protected string factors;
        protected double likelyToPurchase;
        protected double purchaseFactor;
        //constructor


        //member methods
        //likeliness to purchase
        public abstract bool DetermineLikelyToPurchase(Player player, Weather weather);

        //protected void LikelyToPurchase(string[] factors)
        //{
        //    string[,] purchaseFactors = { { "low", "med", "high" }, { "sweet", "sour", "balanced" }, { "sunny", "rainy", "cool" } };

        //}
    }
}
