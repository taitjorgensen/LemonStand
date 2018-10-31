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
        private void DetermineCosts(Player player)
        {
            DetermineCostOfCups(player);
            DetermineCostOfIce(player);
            DetermineCostOfLemons(player);
            DetermineCostOfSugar(player);
        }
        public double TotalPurchases(Player player)
        {
            DetermineCosts(player);
            return purchases = (costOfCups + costOfIce + costOfLemons + costOfSugar);
        }
        double DetermineCostOfCups(Player player)
        {
            return costOfCups = (player.inventory.cupsPurchased * priceOfCups);
        }
        double DetermineCostOfIce(Player player)
        {
            return costOfIce = (player.inventory.icePurchased * priceOfIce);
        }
        double DetermineCostOfLemons(Player player)
        {
            return costOfLemons = (player.inventory.lemonsPurchased * priceOfLemon);
        }
        double DetermineCostOfSugar(Player player)
        {
            return costOfSugar = (player.inventory.sugarPurchased * priceOfSugar);
        }
    }
}
