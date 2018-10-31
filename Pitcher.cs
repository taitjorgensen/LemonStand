using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Pitcher
    {
        public double price;
        private int lemonsUsed;
        private int sugarUsed;
        private int iceUsed;
        private int cupsPerPitcher = 10;
        private int cupsAvailable;
        public void AdjustInventory(Player player, Inventory inventory, Recipe recipe)
        {

            lemonsUsed = recipe.lemonsPerPitcher;
            sugarUsed = recipe.cupsOfSugarPerPitcher;
            iceUsed = recipe.cubesOfIcePerPitcher;
            inventory.AdjustLemonInventory(lemonsUsed);
            inventory.AdjustSugarInventory(sugarUsed);
            inventory.AdjustIceInventory(iceUsed);

        }
        public int CurrentAvailableCups(Player player)
        {

            return cupsAvailable = cupsPerPitcher * player.pitchersMade;
        }
    }
}
