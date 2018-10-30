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

        public void SetUp(Game player)
        {
            inventory.PurchaseInventory(player);
            recipe.SetRecipe();
        }
        
    }
}
