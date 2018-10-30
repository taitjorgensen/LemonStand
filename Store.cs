using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Store
    {
        //member variables
        
        public double priceOfLemon = .40;
        public double priceOfSugar = .10;
        public double priceOfIce = .01;
        public double priceOfCups = .05;
        private double costOfCups;
        private double costOfLemons;
        private double costOfIce;
        private double costOfSugar;
        public double purchases;

        //constructor


        // member methods
        private void DetermineCosts(Inventory inventory)
        {
            DetermineCostOfCups();
            DetermineCostOfIce();
            DetermineCostOfLemons();
            DetermineCostOfSugar();
            double DetermineCostOfCups()
            {
                return costOfCups = (inventory.cupsPurchased * priceOfCups);
            }
            double DetermineCostOfIce()
            {
                return costOfIce = (inventory.icePurchased * priceOfIce);
            }
            double DetermineCostOfLemons()
            {
                return costOfLemons = (inventory.lemonsPurchased * priceOfLemon);
            }
            double DetermineCostOfSugar()
            {
                return costOfSugar = (inventory.sugarPurchased * priceOfSugar);
            }
        }
        public double TotalPurchases()
        {
            DetermineCosts(player.inventory);
            return purchases = (costOfCups + costOfIce + costOfLemons + costOfSugar);
        }

    }
}
