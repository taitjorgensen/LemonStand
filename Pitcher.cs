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
        private int lemonadeAvailable;
        public void AdjustInventory(Player player, Inventory inventory, Recipe recipe)
        {

            lemonsUsed = recipe.lemonsPerPitcher;
            sugarUsed = recipe.cupsOfSugarPerPitcher;
            iceUsed = recipe.cubesOfIcePerPitcher;
            inventory.AdjustLemonInventory(lemonsUsed);
            inventory.AdjustSugarInventory(sugarUsed);
            inventory.AdjustIceInventory(iceUsed);

        }
        public int InitialAvailableLemonade(Player player)
        {
            return lemonadeAvailable = cupsPerPitcher * player.pitchersMade;
        }
        public int CurrentAvailableLemonade()
        {
            if(lemonadeAvailable == 0)
            {
                Console.Write("No!");
            }
            return (lemonadeAvailable - 1);
        }
    }
}
