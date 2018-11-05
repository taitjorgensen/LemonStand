using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Pitcher
    {
        Player player;
        Store store;
        public int lemonsUsed;
        private int sugarUsed;
        private int iceUsed;
        private int cupsPerPitcher = 10;
        private int lemonadeAvailable;
        public void AdjustInventory(Player player, Inventory inventory, Recipe recipe)
        {

            lemonsUsed = recipe.lemonsPerPitcher;
            sugarUsed = recipe.cupsOfSugarPerPitcher;
            iceUsed = recipe.cubesOfIcePerPitcher;
            inventory.AdjustInventory(player, lemonsUsed, sugarUsed, iceUsed);
            //inventory.AdjustSugarInventory(player, sugarUsed);
            //inventory.AdjustIceInventory(player, iceUsed);

        }
        public int InitialAvailableLemonade(Player player)
        {
            return lemonadeAvailable = cupsPerPitcher * player.pitchersMade;
        }
        public int CurrentAvailableLemonade(Game game)
        {
            if(lemonadeAvailable == 0)
            {
                Console.Write("Sold Out!");
                game.RunGame(player, store);
            }
            return (lemonadeAvailable - 1);
        }
    }
}
