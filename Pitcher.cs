using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Pitcher
    {
        public int lemonsUsed;
        private int sugarUsed;
        private int iceUsed;
        public int cupsPerPitcher = 10;
        
        public void AdjustInventory(Player player, Inventory inventory, Recipe recipe)
        {

            lemonsUsed = recipe.lemonsPerPitcher;
            sugarUsed = recipe.cupsOfSugarPerPitcher;
            iceUsed = recipe.cubesOfIcePerPitcher;
            inventory.AdjustInventory(player, lemonsUsed, sugarUsed, iceUsed);
            //inventory.AdjustSugarInventory(player, sugarUsed);
            //inventory.AdjustIceInventory(player, iceUsed);

        }

        public int CurrentAvailableLemonade(Player player)
        {
            if(player.lemonadeAvailable == 0)
            {
                
                return player.lemonadeAvailable;
            }
            return (player.lemonadeAvailable - 1);
        }
    }
}
