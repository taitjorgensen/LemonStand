using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonStand
{
    class Player
    {
        Recipe recipe = new Recipe();
        Inventory inventory = new Inventory();
        public double price = 0;
        public int pitchersMade = 0;

        public void SetUp(Player player, Store store, Day day)
        {
            inventory.PurchaseInventory(player, store, day);
            recipe.SetRecipe(player, store, day);

            Console.WriteLine("How many Pitchers will you make?");
            pitchersMade = int.Parse(Console.ReadLine());
            for (int i = 0; i < pitchersMade; i++)
            {
                Pitcher pitcher = new Pitcher();
                pitcher.AdjustInventory(player, inventory, recipe);
            }
            
        }
        
    }
}
