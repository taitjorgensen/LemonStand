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
            DetermineCostOfCups(inventory);
            DetermineCostOfIce(inventory);
            DetermineCostOfLemons(inventory);
            DetermineCostOfSugar(inventory);
        }
        public double TotalPurchases(Player player)
        {
            DetermineCosts(inventory);
            return purchases = (costOfCups + costOfIce + costOfLemons + costOfSugar);
        }
        double DetermineCostOfCups(Inventory inventory)
        {
            return costOfCups = (inventory.cupsPurchased * priceOfCups);
        }
        double DetermineCostOfIce(Inventory inventory)
        {
            return costOfIce = (inventory.icePurchased * priceOfIce);
        }
        double DetermineCostOfLemons(Inventory inventory)
        {
            return costOfLemons = (inventory.lemonsPurchased * priceOfLemon);
        }
        double DetermineCostOfSugar(Inventory inventory)
        {
            return costOfSugar = (inventory.sugarPurchased * priceOfSugar);
        }
    }
}
